main: main.c utility.o utility.h
	gcc main.c -o main utility.o utility.h

utility.o: utility.c
	gcc utility.c -c

clean:
	rm main utility.o