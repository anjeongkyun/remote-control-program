# 원격 제어 프로그램 개발

## 목차
* **[기술 스택](#기술-스택)**
* **[프로젝트 구조](#프로젝트-구조)**
* **[프로젝트 설명](#프로젝트-설명)**

<br><hr><br>

## 기술 스택
* C#
* .Net Framework (v4.5)
* Windows Forms
* TCP/IP Socket Library
* Win32 API (Windows Hooking)

<br><hr><br>

## 프로젝트 구조
![image](https://user-images.githubusercontent.com/97106584/182016551-6165c3dd-2a5b-4386-8528-34c1c156598f.png)

<br><hr><br>

## 프로젝트 설명
tcp/ip를 이용하여 teamviewer와 anydesk와 같은 **원격 제어 프로그램을 구현**하였습니다.
<br><br>
 주요 기능으론 외부 원격지로 접속한 후 win32 api를 사용하여 **윈도우 기능을 후킹하여 화면 공유 및 클릭 기능 사용**할 수 있도록하는 기능이 있습니다
