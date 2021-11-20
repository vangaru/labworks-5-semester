#include <iostream>
#include <bitset>

using namespace std;

int main() {
    bitset<4> mask { 0 };
    cout << mask << endl;

    unsigned short num = 9;
    bitset<4> num_bitset { num };
    cout << num_bitset << endl;

    cout << "Enter number of the bit to revert( < 4): ";
    int n;
    cin >> n;
    mask[3 - n] = 1;
    cout << mask << endl;

    num_bitset = mask ^ num_bitset;
    cout << num_bitset;
}
