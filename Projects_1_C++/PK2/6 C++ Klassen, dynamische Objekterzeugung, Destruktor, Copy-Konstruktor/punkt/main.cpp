#include "punkt.h"
#include <iostream>

void print(Punkt p){
    std::cout << p.to_string() << std::endl;
}

int main(){

    Punkt s {100, 500};
    Punkt *p = new Punkt {900,1000};

    std::cout << s.getX() << std::endl;
    std::cout << p->getX() << std::endl;

    delete p;
    /*
    Punkt p {200,500};
    Punkt s {p};

    print(s);

    std::cout << p.to_string() << std::endl;
    */

    //Punkt p[100];
    return 0;
}