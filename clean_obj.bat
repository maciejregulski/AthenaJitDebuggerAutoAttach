
for /f "tokens=*" %%G in ('dir /b /ad /s bin') do rmdir /s /q %%G
for /f "tokens=*" %%G in ('dir /b /ad /s obj') do rmdir /s /q %%G

rem del /s /q *.user
rem del /s /ah /q *.suo

pause

