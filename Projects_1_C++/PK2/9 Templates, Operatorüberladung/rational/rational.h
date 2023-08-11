#include <iostream>

class rational{
  private:
    int zaehler;
    int nenner;
  public:
     rational(int zaehler, int nenner);
     //rational operator*(rational r);
     friend rational operator*(rational l, rational r);
     friend std::ostream& operator<<(std::ostream& out, rational r);

};