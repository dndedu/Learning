#include "stack.h"
#include <iostream>

int main(){
    Stack s;
    
    s.push(10);
    s.push(100);

    Stack p {s};

    std::cout << s.pop() << std::endl;
    std::cout << p.pop() << std::endl;
    return 0;
}