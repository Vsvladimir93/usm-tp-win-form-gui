@echo off
echo [33mVetClinic App compile[0m
echo [0m[0m
IF EXIST ["./VetClinic.exe"] (
	del "./VetClinic.exe"
)

csc -target:exe -out:VetClinic.exe -recurse:*.cs

echo [32mVetClinic App run[0m
start /d "." VetClinic.exe