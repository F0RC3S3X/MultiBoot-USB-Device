// Beginn des Skriptes (Wofuer?)
@echo off
title Microsoft Windows - Windows Server Activation Script
color
echo.

:Auswahlmenu
cls
echo.
echo HAUPTMENU
echo ====================================================================================================
echo.
echo [1] Zeige Informationen zur derzeitigen Version des Betriebsystems
echo.
echo [2] Upgrade Moeglichkeiten Ueberpruefen
echo.
echo [3] Upgrade auf Windows Server 2012 DataCenter
echo.
echo [4] Upgrade auf Windows Server 2012 Standard
echo.
echo [5] Upgrade auf Windows Server 2016 DataCenter
echo.
echo [6] Upgrade auf Windows Server 2016 Standard
echo.
echo [7] Upgrade auf Windows Server 2019 DataCenter
echo.
echo [8] Upgrade auf Windows Server 2019 Standard
echo.
echo [9] Upgrade auf Windows Server 2022 DataCenter
echo.
echo [0] Upgrade auf Windows Server 2022 Standard
echo.
echo [X] Beenden
set asw=0
set /p asw="Bitte ein Auswahl treffen: "

if %asw%==1 goto Option1
if %asw%==2 goto Option2
if %asw%==3 goto Option3
if %asw%==4 goto Option4
if %asw%==5 goto Option5
if %asw%==6 goto Option6
if %asw%==7 goto Option7
if %asw%==8 goto Option8
if %asw%==9 goto Option9
if %asw%==0 goto Option0
if %asw%==X goto END
goto END

// Ende des Skripts

:Option1
cls
echo.
DISM /online /Get-CurrentEdition
pause
goto Auswahlmenu

:Option2
cls
echo.
DISM /online /Get-TargetEditions
echo.
pause
goto Auswahlmenu

:Option3
cls
echo.
echo Du hast den dritten Server gewählt!
C:\A2Server\arma2oaserver.exe -port=2302 -name=server -profiles=server -cfg=server\basic.cfg -config=server\server.cfg -mod=@CBA;@CBA_A2;@CBA_OA;@ACE;@STALKER;
echo.
pause
goto Auswahlmenu

:Option4
cls
echo.
echo Du hast den vierten Server gewählt!
C:\A2DayzCoop\server.bat
echo.
pause
goto Auswahlmenu

:Option5
cls
echo.
DISM /online /Set-Edition:ServerStandard /ProductKey:CB7KF-BWN84-R7R2Y-793K2-8XDDG /AcceptEula
echo.
pause
goto END

:Option6
cls
echo.
DISM /online /Set-Edition:ServerDatacenter /ProductKey:CB7KF-BWN84-R7R2Y-793K2-8XDDG /AcceptEula
echo.
pause
goto Auswahlmenu

:Option7
cls
echo.
DISM /online /Set-Edition:ServerStandard /ProductKey:N69G4-B89J2-4G8F4-WWYCC-J464C /AcceptEula
echo.
pause
goto END

:Option8
cls
echo.
DISM /online /Set-Edition:ServerDatacenter /ProductKey:WMDGN-G9PQG-XVVXX-R3X43-63DFG /AcceptEula
echo.
pause
goto Auswahlmenu

:Option9
cls
echo.
DISM /online /Set-Edition:ServerStandard /ProductKey:VDYBN-27WPP-V4HQT-9VMD4-VMK7H /AcceptEula
echo.
pause
goto END

:Option0
cls
echo.
DISM /online /Set-Edition:ServerDatacenter /ProductKey:WX4NM-KYWYW-QJJR4-XV3QB-6VM33 /AcceptEula
echo.
pause
goto Auswahlmenu


:END
echo.
ECHO    Auf Wiedersehen!
ECHO.
pause
