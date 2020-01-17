mkdir bin
csc.exe /out:bin\lwolf-checkpoint1.exe /target:exe Program.cs
setx PATH "%cd%\bin;%PATH%"
