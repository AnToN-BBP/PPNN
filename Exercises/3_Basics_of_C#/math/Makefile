MCS = mcs  # Mono C# compiler

all: main.exe

sfuns.dll: sfuns.cs
	$(MCS) -target:library -out:sfuns.dll sfuns.cs

main.exe: main.cs sfuns.dll
	$(MCS) -target:exe -out:main.exe -reference:sfuns.dll main.cs

run:
	mono main.exe

clean:
	rm -f sfuns.dll main.exe Out.txt
