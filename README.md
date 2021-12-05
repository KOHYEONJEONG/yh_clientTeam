# yh_clientTeam
## 목차
1. [프로그램 설명](#프로그램-설명) 
2. [주요 기능](#주요-기능)
3. [담당 부분 코드](#담당-부분-코드)

## 프로그램 설명
### 유한대학교 캡스톤 디자인 교수 프로그램(신희찬)
### C# Winform 사용
![image](https://user-images.githubusercontent.com/90231631/144753042-37061a03-c01e-45f9-99ff-9e7dceedb1c6.png)

<br/><img src="https://user-images.githubusercontent.com/90231631/144565082-bea16a39-a8b3-4803-a245-0dc2fb052da2.png" width="300px" height="200px"></img><br/>
### 외부 서버와 Oracle DB 사용
![image](https://user-images.githubusercontent.com/90231631/144752830-ae13d0ca-a5ba-4900-952a-1df41ee806aa.png)<br/>

비대면 실시간 강의 시 학습을 도와주는 프로그램. 
비대면 학생들이 학교 통신망에 접근 불가능 하므로 외부 서버를 사용하여 통신
<br/><img src="https://user-images.githubusercontent.com/90231631/144564614-05a40292-bb27-4e0a-8c3a-17e005358dba.png" width="300px" height="200px"></img><br/>
데이터의 저장은 Oracle DB 사용
<br/>![image](https://user-images.githubusercontent.com/90231631/144752830-ae13d0ca-a5ba-4900-952a-1df41ee806aa.png)<br/>



학생은 대표적으로 출석기능과 모르는 부분은 바로 질문할 수 있는 기능있어 수업에 집중하기 편함.</br>
교수님은 대표적으로 스크린샷 요청하여 학생PC를 확인할 수 있고 수업을 이해했는지 문제를 낼 수 있어 관리하기 편함.

## 주요 기능
<img src="https://user-images.githubusercontent.com/90231631/144564335-64af9f11-72ef-4915-93f8-632133a654cc.png" width="450px" height="300px"></img><br/>
1.문제전송 기능
학생을 선택하여 단답형 또는 ox퀴즈 문제를 보낼 수 있음. 
<br/><img src="https://user-images.githubusercontent.com/90231631/144563644-a1fa8720-d814-4b50-8f88-3234b4d0eff6.png" width="450px" height="300px" title="문제전송 폼"></img><br/>
//문제 전송 시 학생측에 뜨는 폼
<br/><img src="https://user-images.githubusercontent.com/90231631/144563953-06625e76-0e5b-43e7-bd70-417b5637e0f1.png" width="600px" height="200px"></img><br/>

2.스크린샷 기능
버튼을 누르면 선택 학생의 현재화면을 스크린샷 해서 가져옴
스크린샷 썸네일 사진위에 마우스를 올려두면 썸네일 미리보기가 뜸
<br/><img src="https://user-images.githubusercontent.com/90231631/144565489-0c43262a-8577-4d5a-ba45-d9a18dfe5c55.png" width="300px" height="200px"></img></br>

//썸네일 더블클릭 시 뜨는 화면
<br/><img src="https://user-images.githubusercontent.com/90231631/144565834-f478420f-d3e8-4232-94f2-e3bd8cdb14bd.png" width="450px" height="300px"></img></br>

//학생 응답시 리스트에 해당 학생 응답 셀에 응답 내용이 들어감</br>
//응답 내용 더블클릭 시 뜨는 폼
<br/><img src="https://user-images.githubusercontent.com/90231631/144566304-6360ed46-e69f-4752-b62d-78c80ba95eda.png" width="600px" height="200px"></img><br/>

3.출석부 기능
학생들의 출석 기록을 확인
<br/><img src="https://user-images.githubusercontent.com/90231631/144563038-593804b8-64af-4cff-a935-cc7e6b4aadf7.png" width="450px" height="300px"></img><br/>
주마다 각 교시의 출결 상태를 보여준다.

4.출석시작(수업 종료) 버튼
각 교시가 시작할 때 마다 버튼이 활성화 되어 출석을 시작 할 수 있음
수업종료 5분전에 수업 종료 버튼으로 바뀐다.

5.학생 리스트
미접속 학생의 행을 비활성화 시키고 회색으로 처리
접속 학생은 행을 활성화 시키고 흰색으로 처리

6.학생 질문
학생이 질문을 받을 수 있음</br>
//질문 시 뜨는폼 (이미지와 질문을 받을 수 있음)
<br/><img src="https://user-images.githubusercontent.com/90231631/144566778-6d6ae659-76ff-4354-ad4b-332b97b3fba8.png" width="200px" height="350px"></img><br/>

## 담당 부분 코드
### 서버 요청 보내는 클래스 ,서버 요청 받는 클래스 일부분,  로그인 동작 부분, 교수 메인폼, 출석부
#### 프로젝트 형태
<br/><img src="https://user-images.githubusercontent.com/90231631/144718611-411bb43a-3e7b-4da0-a31f-15b9866a21b3.png" width="200px"></img></br>

### 1.서버 요청 보내는 클래스(SessionManager.cs)
<br/><img src="https://user-images.githubusercontent.com/90231631/144718738-725a4603-4829-4258-a5ec-9f4ef075788e.png" width="600px"></img><br/>
.</br>
.</br>
.(폼 설명에 추가)</br>
### 2.서버 요청 받는 클래스 일부분(CPPacketHandler.cs)
<br/><img src="https://user-images.githubusercontent.com/90231631/144720154-c07a7c9d-eaab-4ef2-a40c-606b8eec9f60.png" width="600px"></img><br/>
.</br>
.</br>
.(폼 설명에 추가)</br>

### 3.로그인 동작 부분(LoginForm.cs)
#### 디자인
![image](https://user-images.githubusercontent.com/90231631/144718962-762847da-7663-46d3-b4a2-0308214afd0e.png)</br>
#### 변수 선언 및 초기화
<img src="https://user-images.githubusercontent.com/90231631/144719004-156adda7-e403-4b32-b2b6-fbcb54d1c72a.png" width="600px"></img><br/>
#### 서버 연결
<img src="https://user-images.githubusercontent.com/90231631/144719569-88cb81c1-2174-4ef7-9aa6-d06aea5816b5.png" width="600px"></img><br/>
#### 로그인 버튼 클릭 시
<img src="https://user-images.githubusercontent.com/90231631/144719673-d6c346cc-6c6b-4925-8774-f137e19a5bc0.png" width="500px"></img><br/>
SessionManager를 통해 서버에 로그인 정보를 보냄
#### 로그인 결과 핸들이 넘어왔는지 감지
<img src="https://user-images.githubusercontent.com/90231631/144720694-e91ae638-89db-43f0-8ec4-600900fa6b23.png" width="600px"></img><br/>
확인 변수가 1이면 로그인 성공 2면 실패</br>
성공일 경우 교수 메인폼을 띄워줌</br>
메인폼에서 수업이 없을을 판단하면 4를 반환 프로그램 종료</br>
실패일 경우 다시 로그인 창을 띄움

#### 서버에서 로그인 시도 결과를 받음
<img src="https://user-images.githubusercontent.com/90231631/144720610-79dc3831-60dc-49da-ae63-3bbc08b511d9.png" width="600px"></img><br/>
로그인 실패 시 SP_LoginFailedHandler가 호출 </br>
로그인 확인 변수의 값을 2로 변경</br>
로그인 성공 시 SP_LoginResultHandler가 호출
로그인 확인 변수의 값을 1로 변경

### 4.교수 메인 폼(ProgessorMain.cs)
#### 디자인
![image](https://user-images.githubusercontent.com/90231631/144720813-eeaf5a2c-6e85-4afc-b3c3-7d0cfad49b3e.png)
#### 변수 선언 및 초기화
<img src="https://user-images.githubusercontent.com/90231631/144721292-b0fb616b-57c0-40bb-ad11-4509c5d9774c.png" width="800px"></img><br/>
#### 수업 정보와 학생 리스트를 저장하는 메서드
<img src="https://user-images.githubusercontent.com/90231631/144752550-bc920eee-a7a0-4e2f-82db-2edceba9521c.png" width="800px"></img><br/>
로그인 후 서버에서 받은 데이터에서 필요한 정보를 가져옴
#### 폼 생성 시 화면에 정보 출력
<img src="https://user-images.githubusercontent.com/90231631/144752630-654f48dc-aa85-43a5-a25a-d1b17718b1bb.png" width="800px"></img><br/>
수강 학생과 수업 정보를 화면에 출력
#### 선택되어 있는 학생을 리스트에 저장하는 메서드


