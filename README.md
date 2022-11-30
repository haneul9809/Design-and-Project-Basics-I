# Design-and-Project-Basics-I
수면 패턴 분석 기기 제작

## 🗓️ 개발 기간

2020/4/20 ~ 2020/6/17

## 📜서비스 내용

- 문제 제기
    - 불면증의 원인을 찾기 위해 개발하게 되었다.
- 문제 해결(기능과 기대효과)
    - 측정된 데이터를 분석해 불면증에 원인이나 다른 질병이 있는지 진단
    - 필요 조건
        - 아두이노나노를 계속 PC에 연결
        - 아크릴판을 사용한 디자인
        - 벽 부착 가능
        - 수면 중 정확한 움직임, 음성 센서 측정 가능
    - 예상 작품 구성도
        
        ![Untitled1](https://user-images.githubusercontent.com/67767912/204771316-01b3b9d5-53c5-435b-88d5-a39f0dd868bf.png)
![Untitled2](https://user-images.githubusercontent.com/67767912/204771336-39d450de-ea66-4329-9141-3ead03d316e8.png)

        
    - 현실적 제한 조건
        <img width="658" alt="스크린샷 2022-11-30 오후 7 27 45" src="https://user-images.githubusercontent.com/67767912/204772312-ce992701-fece-4edf-8552-abfd5f2b7f3f.png">

    
        
    - 기대효과
        - 측정된 수면 습관으로 발생될 수 있는 질환을 진단하고 치료할 수 있다.
        - 불면증이 아니더라도 다른 질병을 미리 알고 예방할 수 있다.


## ⚙️ 기술 스택

- 수면패턴 분석 홈페이지 및 서버
    - Front-end
        - HTML, CSS, JavaScript, 구글 차트
    - Back-end
        - python, flask, MariaDB, MySQL, php, Apache
    - etc
        - VNC 원격 제어
- 수면패턴 분석기기
    - HW
        - Raspberry PI, Arduino, 소리인식센서, 모션인식센서, 초음파센서
        - 3D 프린팅
    - SW
        - C, C++
        - 3D Design 프로그램

## 👫 팀 구성
<img width="665" alt="스크린샷 2022-11-30 오후 7 28 26" src="https://user-images.githubusercontent.com/67767912/204772449-bdac734e-1c4b-4486-91cb-f562cdd6c84c.png">
<img width="661" alt="스크린샷 2022-11-30 오후 7 28 57" src="https://user-images.githubusercontent.com/67767912/204772636-d9caa254-87c1-4a45-a331-a1987968e5e0.png">


## 💻 개발 내용

1. 시스템 구성도
    <img width="665" alt="스크린샷 2022-11-30 오후 7 29 48" src="https://user-images.githubusercontent.com/67767912/204772789-483116fe-a27b-4917-bb8a-e6183e092091.png">

    
2. 케이스 제작
    
    ![Untitled7](https://user-images.githubusercontent.com/67767912/204771506-da0b5c28-e9e6-433c-8c6f-55e07418dce6.png)
    ![Untitled8](https://user-images.githubusercontent.com/67767912/204771514-caf148d8-05c4-4ff0-ba6a-840d790f97c6.png)

    
    - 123D Design 프로그램으로 제작
    - PLA재질의 노란색 불투명 필라멘트를 재료로 함
    - 초음파센서를 사용하기 위해 적합한 원형 모양으로 구상
3. 라즈베리파이
    ![Untitled9](https://user-images.githubusercontent.com/67767912/204771570-f63cee8f-b24c-42b0-a3a5-36ae55952967.png)

    
    - 라즈베리파이를 PC에서 조작하기 위해 VNC 원격제어 도구를 사용했다.
4. APM 서버 구축
    - 웹서버 명령 처리를 위해 python 사용이 필요했고, python을 사용하기 위해 flask를 설치하였다.
    - 웹서버 생성을 위해 Apache를 사용해 서버를 구축했다.
    - MariaDB와 MySQL을 설치하고 php(phpmyadmin)를 활용해 웹과 DB와 서버를 연동했다.
5. 웹 개발
    - HTML, CSS, JavaScript, 구글 차트를 활용하여 웹을 개발했다.
    
    ![Untitled10](https://user-images.githubusercontent.com/67767912/204771650-dee1b6c9-9b78-4b35-bb0d-624722f474bc.png)

6. 소리 센서, 모션 센서
    - 아두이노IDE을 통해 코드를 작성했다.
7. 완성
    
    ![Untitled11](https://user-images.githubusercontent.com/67767912/204771690-b85289fe-7bc1-4340-ab39-c6a6df19bbfc.png)


## 💻 내가 담당한 파트

[라즈베리파이](https://www.notion.so/0cca01e696c24180a866984a292974a0) 

[APM 서버 구축](https://www.notion.so/APM-d3c4489f473a4e9e91d44170b87d29f9) 

[웹 개발](https://www.notion.so/de5ed13e471f4784a97918100dfa71c7) 

## 🗓️ 추진 일정
![Untitled12](https://user-images.githubusercontent.com/67767912/204771744-aaa2c075-db55-4678-b9fe-70d21806c768.png)


## ✏️후기 및 에세이

아쉬운 점은 서툴었던 점이다. 정보가 많아 충돌이 많았으며, 기기를 다루는 데에 미숙했다. 그리고 실현하고자 하는 부분이 많아서 완벽하게 완성하지 못했다.

서툴어서 개발 과정 중 실수로 인해 micro SD카드를 자주 포맷했다. 첫번째는 설치 미숙으로 인한 이중 설치, 두번째는 IP 주소의 혼란 및 설치 오류, 세번째는 와이파이가 연결이 되지 않는 희대의 미스테리한 상황 발생, 네번째는 mysql의 root권한을 잘못 건드려 의존성 문제가 발생하여 db접근 불가능, 다섯번째는 phpmyadmin이 php에 혼선을 주어 에러가 뜸, 여섯번째는 설치한 프로그램이 많아 충돌로 인해 phpmyAdmin 접근 불가였다.
