#include <ESP8266HTTPClient.h>
#include <BearSSLHelpers.h>
#include <CertStoreBearSSL.h>
#include <ESP8266WiFi.h>
#include <ESP8266WiFiAP.h>
#include <ESP8266WiFiGeneric.h>
#include <ESP8266WiFiGratuitous.h>
#include <ESP8266WiFiMulti.h>
#include <ESP8266WiFiScan.h>
#include <ESP8266WiFiSTA.h>
#include <ESP8266WiFiType.h>
#include <WiFiClient.h>
#include <WiFiClientSecure.h>
#include <WiFiClientSecureAxTLS.h>
#include <WiFiClientSecureBearSSL.h>
#include <WiFiServer.h>
#include <WiFiServerSecure.h>
#include <WiFiServerSecureAxTLS.h>
#include <WiFiServerSecureBearSSL.h>
#include <WiFiUdp.h>

const char* ssid = "ssjj04";
const char* password = "ssjj0402";
String host = "http://172.20.10.4";  // ~S ifconfig  (무선ip주소확인)

int trigPin = 5;        // 초음파 센서 (D1)
int echoPin = 4;        // 초음파 센서 (D2)
int inputPin = 13;     // PIR 센서 신호핀(D7)
int SoundSensor = A0;   // 사운드 센서(A0)

int dis, du;
int Sounds;
int valPIR;
int cnt = 0;
int tcnt = 0;
int php_cnt = 0;
int flag = 0;

unsigned long newTime = 0; 
unsigned long interval = 10000;
WiFiServer server(80);
WiFiClient client;
HTTPClient http;

void setup(){
  Serial.begin(115200);
 
  WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, password);
 
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("Connecting to ");
  Serial.println(ssid);
  Serial.print("IP Address: ");
  Serial.println(WiFi.localIP());
  server.begin();
  Serial.println("Server started");
  newTime = interval;
}

float getDuration(){
  float duration;
  duration = pulseIn(echoPin,HIGH);
  return(duration);
}

float getDistance(){
  long distance;
  digitalWrite(trigPin, LOW);
  delayMicroseconds(10);
  digitalWrite(trigPin, HIGH);
  distance = ((float)(340 * getDuration()) / 1000) / 2;
  return(distance);
}

int getSound(){
  int sound;
  sound = analogRead(SoundSensor);
  return sound;
}

int getPIR(){
  int val = 0;
  val = digitalRead(inputPin);
  return val;
}

void check_sensors(){
  if(millis()-newTime < interval) return;

  dis[cnt] = getDistance(); // 거리를 받아서 변수에 입력
  du[cnt] = getDuration(); // 시간을 받아서 변수에 저장
  Sounds[cnt] = getSound(); // 사운드 값을 받음.
  valPIR[cnt] = getPIR();  // PIR센서 값을 받음.

  Serial.print(cnt+1+tcnt);
  Serial.print("  Distance : ");
  Serial.print(dis[cnt]);
  Serial.print("  PIR : ");
  Serial.print(valPIR[cnt]);
  Serial.print(" Sound : ");
  Serial.print(Sounds[cnt]);

  String phpHost = host + "/insert.php?ULTRAsensor = "+String(dis[cnt])+"&PIPsensor = "+String(valPIR[cnt])+"&SOUNDsensor = "+String(Sounds[cnt]);
    Serial.print("Connect to ");
    Serial.println(phpHost);

    http.begin(espClient, phpHost);
    http.setTimeout(1000);
    int httpCode = http.GET();

    if(httpCode > 0)
    {
      Serial.printf("GET code : %d\n\n", httpCode);
      if(httpCode == HTTP_CODE_OK)
      {
        String payload = http.getString();
        Serial.print(payload);
      }
    }
    else
    {
      Serial.printf("GET failed, error: %s\n", http.errorToString(httpCode).c_str());
    }
   http.end(); 

   cnt++;
   flag = 1;

   newTime = millis();
}

void loop(){
  check_sensors();
  client = server.available();

  if(!client) return;

  //  Serial.println("새로운 클라이언트");
  client.setTimeout(5000);
 
  String request = client.readStringUntil('\r');
//  Serial.print("request: ");
//  Serial.println(request);
 
  while(client.available()) {
    client.read();
  }

  client.print("HTTP/1.1 200 OK");
  client.print("Content-Type: text/html\r\n\r\n");
  client.print("<!DOCTYPE HTML>");
  client.print("<html>");
  client.print("<head>"); 
  client.print("<meta charset=\"UTF-8\" http-equiv=\"refresh\" content=\"10\">");
  client.print("<title>DHT senrsor test Webpage</title>");
  client.print("</head>");
  client.print("===================================");
  client.print("<h2>▶ Sleep Pattern </h2>");
  client.print("===================================");
  client.print("<br>");
  client.print("<br>");  

  for(int i=0; i<cnt;i++){
    client.print("&nbsp;&nbsp;");
    client.print("count : ");
    php_cnt = i+1+tcnt;
    client.print(php_cnt);
    client.print("&nbsp;&nbsp;&nbsp;");
    client.print("Distance : ");
    client.print(dis[i]);
    client.print(" mm");
    client.print("&nbsp;&nbsp;&nbsp;");
    client.print("PIR : ");
    client.print(valPIR[i]);
    client.print(" , ");
    client.print("&nbsp;&nbsp;&nbsp;");
    client.print("SOUND : ");
    client.print(Sounds[i]);
    client.print(" , ");
    client.print("<br>");
    client.print("--------------------------------");
    client.print("--------------------------------");
    client.print("<br>");
  }
  client.print("</html>");

  if((flag) && (cnt >= 5)){
    flag = 0;
    cnt = 0;
    tcnt +=5;
  }
}
