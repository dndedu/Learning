hallo: hallo.c
	gcc hallo.c -o hallo

ggt.s: ggt.c
	gcc -S ggt.c

ggt.o: ggt.c
	gcc -c ggt.c

calcggt: calcggt.c ggt.o ggt.h
	gcc calcggt.c -o calcggt ggt.o ggt.h

clean:
	rm hallo ggt.s ggt.o calcggt