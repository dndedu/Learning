#include <stdio.h>
#include "stack.h"

int str_laenge(char text[]){
  int c = 0;
  while(text[c]){
    c++;
  }
  return c;
}


int main(){
  int i;
  for(i = 1; i<=10;i++){
    push(i);
  }
  for(i = 0; i < 10;i++){
    printf("%d\n", pop());
  }

  char t[]="Hallo";
  printf("Laenge = %d\n", str_laenge(t));

}
