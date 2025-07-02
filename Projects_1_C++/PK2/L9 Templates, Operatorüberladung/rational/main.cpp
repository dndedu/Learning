#include "rational.h"

int main(){
    rational l {4,5};
    rational r {3,7};

    std::cout << l << "*" << r << "=" << l * r << std::endl;  
    //std::cout << l << "*" << r << "=" << l.operator*(r) << std::endl; 
    //std::cout << l << "*" << r << "=" << operator*(l, r) << std::endl;  
    return 0;
}