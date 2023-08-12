#include "rational.h"

rational::rational(int zaehler, int nenner) : zaehler {zaehler}, nenner {nenner} {}

/*
rational rational::operator*(rational r){
    rational neu {this->zaehler * r.zaehler, this->nenner * r.nenner};
    return neu;
}
*/

rational operator*(rational l, rational r){
    rational neu {l.zaehler * r.zaehler, l.nenner * r.nenner};
    return neu;
}

std::ostream& operator<<(std::ostream& out, rational r){
    out << "(" << r.zaehler << "/" << r.nenner << ")";
    return out;
}