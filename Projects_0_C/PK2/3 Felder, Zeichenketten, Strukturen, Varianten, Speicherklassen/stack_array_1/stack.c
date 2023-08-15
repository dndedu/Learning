#define MAX 10

int stack[MAX];
int top = -1;


int push(int key){
  if(top < MAX -1){
    stack[++top] = key;
    return 1;
  } else {
    return 0;
  }
}

int pop(){
  if(top > -1){
    return stack[top--];
  } else {
    //Konvention
    return -1;
  }
}
