#include "stack.h"

Stack::Stack() : top {nullptr}{

}

Stack::~Stack(){
    while(pop()!=-1);
}

int Stack::push(long k){
    element *neu = new element {k, top};
    if (neu != nullptr){
        top = neu;
        return 1;
    } else {
        return 0;
    }
}

long Stack::pop(){
   if (top!=nullptr){
      long k = top->key;
      element *tmp = top;
      top = top->next;
      delete tmp;
      return k;
   } else {
     return -1;
   }

}