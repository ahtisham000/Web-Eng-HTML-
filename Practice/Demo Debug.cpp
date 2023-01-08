#include<iostream>
using namespace std;
class Parent
{
public:
   
void print() {
        cout << "This is parent class's Function" << endl;
    }
};
class Child:parent
{
    void print() {
        cout << "This is child class's Function" << endl;
    }
};
 int main() {
    Child child1;
    child1.print();
    return 0;
}
