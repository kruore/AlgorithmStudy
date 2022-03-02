#include <iostream>
#include <string>

using namespace std;

int solution(int n, int m)
{
	int sum=0;

	for (int i = 0; i <= n; i+m)
	{
		sum += i;
		i += m;
	}

	return sum;
}


int main()
{
	int data = solution(100, 1);
	cout << data;
}