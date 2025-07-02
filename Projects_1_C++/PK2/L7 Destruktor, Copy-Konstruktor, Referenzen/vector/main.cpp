#include <iostream>
#include "vector.h"

int main()
{
    Vector v{10};

    v.set(1, 200.0);

    Vector w{v};

    w.set(0, 100.0);

    std::cout << w.get(1) << std::endl;

    return 0;
}