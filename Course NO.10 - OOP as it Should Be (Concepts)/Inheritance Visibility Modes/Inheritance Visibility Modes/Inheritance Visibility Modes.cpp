#include <iostream>

using namespace std;

class clsA
{
private:
    //only accessible   inside this class, neither derived classes nor outside class.
    int _Var1;
    void _Fun1()
    {
        cout << "Function 1";
    }

protected:
    //only accessible  inside this class and all derived classes, but not outside class
    int Var2;
    void Fun2()
    {
        cout << "Function 1";
    }

public:
    // Accessable inside this class, all derived classes, and outside class
    int Var3=2005;

    void Fun3()
    {
        cout << "Function 1";
    }
  //  friend int main();
   // friend class clsB;
};
class clsB :public clsA
{

public:
   /// clsA::Var3;

    void Fun1(clsA B)
    {
      
        cout << B.Fun3();
    }
    
};


class clsC : public clsB {

public:
    int Var5;
    void Fun5() {

        cout <<"a";

    }



};

int main()

{
    
    clsB B1;
    clsA * A1 = &B1;

   A1->Fun3();
    system("pause>0");
    return 0;
}