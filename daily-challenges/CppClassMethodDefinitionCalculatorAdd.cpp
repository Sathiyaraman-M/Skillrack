#include<iostream.h>
using namespace std;
class Calculator
{
    public:
    int _a, _b;
    Calculator(int a, int b)
    {
        _a = a;
        _b = b;
    }
    int add()
    {
        return a + b;
    }    
};
int main()
{
    int a, b;
    cin >> a;
    cin >> b;
    Calculator calc{a, b};
    cout << calc.add();
    return 0;
}