# yh_clientTeam
## 유한대학교 캡스톤 디자인 교수 프로그램(신희찬)
![image](https://user-images.githubusercontent.com/90231631/144564773-8c1a7baf-6cad-44ba-a57f-7b787c0eed8e.png)
비대면 실시간 강의 시 학습을 도와주는 프로그램. 
비대면 학생들이 학교 통신망에 접근 불가능 하므로 외부 서버를 사용하여 통신
<br/><img src="https://user-images.githubusercontent.com/90231631/144564614-05a40292-bb27-4e0a-8c3a-17e005358dba.png" width="300px" height="200px"></img><br/>
데이터의 저장은 Oracle DB 사용
<br/><img src="https://user-images.githubusercontent.com/90231631/144565082-bea16a39-a8b3-4803-a245-0dc2fb052da2.png" width="300px" height="200px"></img><br/>

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

## 담당 부분 코드(서버에 요청보내기, 로그인 동작 부분, 교수 메인폼, 출석부, 서버 요청 받기 )
프로젝트 형태
<br/><img src="https://user-images.githubusercontent.com/90231631/144718611-411bb43a-3e7b-4da0-a31f-15b9866a21b3.png" width="200px"></img></br>

1.서버 요청 클래스(SessionManager.cs)
<br/><img src="https://user-images.githubusercontent.com/90231631/144718738-725a4603-4829-4258-a5ec-9f4ef075788e.png" width="600px"></img><br/>
.</br>
.</br>
.(폼 설명에 추가)</br>

