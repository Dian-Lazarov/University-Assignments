//Both vectorsand deques provide a very similar interfaceand can be used for similar purposes, 
//but internally both work in quite different ways : While vectors use a single array that needs 
//to be occasionally reallocated for growth, the elements of a deque can be scattered in different 
//chunks of storage, with the container keeping the necessary information internally to provide 
//direct access to any of its elements in constant timeand with a uniform sequential interface(through iterators).
//Therefore, deques are a little more complex internally than vectors, but this allows them to grow more efficiently 
//under certain circumstances, especially with very long sequences, where reallocations become more expensive.

//https://www.geeksforgeeks.org/deque-cpp-stl/

#include <iostream>
#include <deque>

using namespace std;

void showdq(deque <int> g)
{
    deque <int> ::iterator it;
    for (it = g.begin(); it != g.end(); ++it)
        cout << '\t' << *it;
    cout << '\n';
}

int main()
{
    deque <int> gquiz;
    gquiz.push_back(10);
    gquiz.push_front(20);
    gquiz.push_back(30);
    gquiz.push_front(15);
    cout << "The deque gquiz is : ";
    showdq(gquiz);

    //15 20 10 30
   
    cout << "\ngquiz.size() : " << gquiz.size();
    cout << "\ngquiz.max_size() : " << gquiz.max_size();

    cout << "\ngquiz.at(2) : " << gquiz.at(2);
    cout << "\ngquiz.front() : " << gquiz.front();
    cout << "\ngquiz.back() : " << gquiz.back();
 
    cout << "\ngquiz.pop_front() : ";
    gquiz.pop_front();
    showdq(gquiz);

    cout << "\ngquiz.pop_back() : ";
    gquiz.pop_back();
    showdq(gquiz);
    
    return 0;
}