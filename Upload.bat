@echo off

cd /d "C:\Users\admin\source\repos\PrintTreeProject\PrintTreeProject\bin\Debug"

copy /Y PrintTreeProject.exe C:\Users\admin\Tools\PrintTree.exe
copy /Y PrintTreeProject.exe C:\Users\admin\Tools\pt.exe

cd C:\Users\admin\source\repos\PrintTreeProject

echo Executable copied successfully to Tools folder.
pause