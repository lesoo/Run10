<div align="right">
	<img src="https://github.com/lesoo/Run10/blob/main/10_img/run10.png?raw=true" width="50%">
	</div>

# Run10
### 10분동안 장애물을 피해 달리며 점수를 얻는 미니게임 
<br>

## 개발환경, 언어
 ![Unity](https://img.shields.io/badge/Unity-%23000000?style=for-the-badge&logo=Unity&logoColor=white)
 ![C#](https://img.shields.io/badge/C%20sharp-%23bb55bb?style=for-the-badge&logo=C#&logoColor=white) 
  
<br>

## 진행 구조
 - 애니메이션
	- 게임 시작 -> 플레이어 걷기 애니메이션
	- 플레이어 충돌 -> 충돌감지 -> 플레이어 충돌 애니메이션 + 충돌 이펙트 

 - 충돌 감지
	- 플레이어 충돌 -> 충돌감지 ->  장애물/아이템 구분
	- 장애물 1, 2 -> 충돌 감지 -> 생명 감소 
	- 아이템 1, 2 -> 충돌 감지 -> 아이템 분류 -> 스코어 증가
 - 사운드
 	- 게임 시작 -> bgm 재생
	- 장애물 충돌 -> 충돌 효과음 재생
	- 아이템 획득 -> 획득 효과음 재생
	
- 타이머 감소 -> 타이머 0 -> 게임 클리어

- 생명 0 -> 게임 오버

<br>

## 조작
<table>
	<tr><th>조작 키</th><th>동작</th></tr>
	<tr><td><img src="https://github.com/lesoo/Run10/blob/main/10_img/arrowup.jpeg?raw=true" width="100px">
	<img src="https://github.com/lesoo/Run10/blob/main/10_img/space_bar.jpeg?raw=true" width="200px"></td>
	<td>점프</td></tr>
	<tr><td><img src="https://github.com/lesoo/Run10/blob/main/10_img/arrowup.jpeg?raw=true" width="100px">*2
	<img src="https://github.com/lesoo/Run10/blob/main/10_img/space_bar.jpeg?raw=true" width="200px">*2</td>
	<td>2단 점프</td></tr>
</table>

<br>

## 구성

<table>
	<tr><td>플레이어</td><td>배경 화면</td><td>아이템 1</td></tr>
	<tr><td><img src="https://github.com/lesoo/Run10/blob/main/10_img/player-run-1.png?raw=true" width="250px"></td>
	<td><img src="https://github.com/lesoo/Run10/blob/main/10_img/background.png?raw=true" width="400px">
		</td>
		<td><img src="https://github.com/lesoo/Run10/blob/main/10_img/cherry-1.png?raw=true" width="250px"></td></tr>	
	<tr><td>장애물</td><td>hp/Timer/Score 체력</td><td>아이템2</td>
	</tr>
	<tr><td><img src="https://github.com/lesoo/Run10/blob/main/10_img/eagle-attack-1.png?raw=true" width="250px"></td>
	<td><img src="https://github.com/lesoo/Run10/blob/main/10_img/mini-heart.png?raw=true" width="250px"></td>
		<td><img src="https://github.com/lesoo/Run10/blob/main/10_img/gem-1.png?raw=true" width="250px"></td>
		</tr>	
	
</table>

## 시나리오
<table>
	<tr><td>플레이어</td><td>시작화면</td></tr>
	<tr><td><img src="https://github.com/lesoo/Run10/blob/main/10_img/10_player.PNG?raw=true" width="50%"></td>
	<td><img src="https://github.com/lesoo/Run10/blob/main/10_img/10_1.PNG?raw=true" width="100%">
		</td></tr>	
	<tr><td>플레이 화면</td><td>hp/Timer/Score 표시</td>
	</tr>
	<tr><td><img src="https://github.com/lesoo/Run10/blob/main/10_img/10_ing.PNG?raw=true" width="100%"></td>
	<td><img src="https://github.com/lesoo/Run10/blob/main/10_img/10_hp.PNG?raw=true" width="50%"></td>
		</tr>	
	<tr><td>클리어 화면</td><td>게임 오버</td>
	</tr><tr>
	<td><img src="https://github.com/lesoo/Run10/blob/main/10_img/10_clear.PNG?raw=true" width="100%"></td>
	<td><img src="https://github.com/lesoo/Run10/blob/main/10_img/10_over.PNG?raw=true" width="100%"></td>
	</tr>
</table>


<br>

## 역할
- 게임 디렉터
	- 게임 기획/스케줄링
	- 점수/시간/hp 표시
	- 화면 전환
	- 화면 전환 시 데이터 전송
	- 다른 코드 취합 및 수정


## 어려웠던 점
- 클리어 화면으로 전환 시 점수/체력 데이터를 넘길 수가 없어 어려웠다
	- 전역변수를 선언해 넘겼다
	
- 새 게임 시작 시 점수와 체력이 리셋 되지 않았다.
	- 각각 리셋하는 코드를 삽입했다.
	
- 3명이서 진행한 프로젝트라 2명의 조원이 모두 충돌감지 코드를 입력해서 실행시 오류가 발생했다.
	- 한쪽을 지우고, 아이템과 장애물을 구분하는 코드로 수정하여 진행 했다. 
	
- 게임 디렉터를 맡아 조원들 코드 제출 마감 기한을 넉넉하게 잡아 오류 수정 시간이 촉박했다
	- 게임 개발에 대한 기초적인 지식이 너무 없어, 초기에 계획없이 시작했다.
	- 화면 전환 시 변수를 넘기는 부분을 고려하지 못해 시간이 많이 소요됐다.
	- 계획에 코드 취합/오류 수정 기간도 넣어야겠다. 
	
- 코드 취합 시 Unity버전이 달라 소요시간이 예정과 달리 길어졌다.
	- 개발 전에 버전을 맞추고 시작했어야 했다. 
	
- 개발 환경마다 화면 비율이 달라, 최종 완성본에 플레이어와 스코어보드가 너무 작아서 당황스러웠다.
	- 개발환경을 초기에 맞추고 시작해야겠다.
	
- 발표 때 우리 조 발표자료만 너무 빈약해서 놀랐다.
	- 작업한 내용을 하나하나 기록하는 습관을 들여야겠다.
	- 디벨롭 할 때 발표자료도 새로 만들 것이다.
	
- 게임이 너무 간단하다
	- 약간의 스토리를 넣어 RPG형식으로 발전 시키면 재미있을 것 같다.

