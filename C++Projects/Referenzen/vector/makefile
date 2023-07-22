#main, vector
main.exe: main.cpp vector.o vector.h
	g++ main.cpp -o main.exe vector.o vector.h

vector.o: vector.cpp vector.h
	g++ vector.cpp -c

clean:
	rm vector.o swap.exe main.exe swap.o