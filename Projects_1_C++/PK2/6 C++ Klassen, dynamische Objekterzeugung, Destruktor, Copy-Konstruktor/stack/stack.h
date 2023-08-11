#include <iostream>

class Stack{
  private:
    struct element{
      long key;
      element *next;

      element(long key, element *next) : key {key}, next {next}{}
      // Wird hier nicht benoetigt. Dient nur der Veranschaulichung.
      ~element(){
        std::cout << "Destruktur" << std::endl;
      }
    };
    element *top;

  public:
    Stack();
    ~Stack();
    int push(long key);
    long pop();
};