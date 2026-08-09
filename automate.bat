@echo off
@cls
@color f0
for /F "tokens=*" %%A in (%1) do .\expre.exe %%A
