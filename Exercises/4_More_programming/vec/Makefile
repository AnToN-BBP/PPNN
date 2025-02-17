# Choose C# compiler
CSC = mcs

# 'all' depends on 'out.txt', which will cause everything to build and run.
PHONY: all
all: out.txt
	cat out.txt

# Produce out.txt by running main.exe
out.txt: main.exe
	mono main.exe > out.txt

# Build the main.exe by referencing vec.dll
main.exe: main.cs vec.dll
	$(CSC) -out:$@ -reference:vec.dll main.cs

# Build vec.dll as a library
vec.dll: vec.cs
	$(CSC) -target:library -out:$@ vec.cs

# Clean up
clean:
	$(RM) *.exe *.dll [Oo]ut*.txt
