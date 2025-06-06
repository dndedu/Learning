calcggt: calcggt.c ggt.o ggt.h
	gcc calcggt.c -o calcggt ggt.o ggt.h

ggt.s: ggt.c
	gcc -S ggt.c

ggt.o: ggt.c
	gcc -c ggt.c

clean:
	rm ggt.s ggt.o calcggt