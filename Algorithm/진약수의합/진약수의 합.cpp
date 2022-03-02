// 진약수  = 자기 자신을 제외한 약수
#include <iostream>

using namespace std;

int solution(int length)
{
	int count= 0 ;
	//for (int i = 1; i < length; i++)
	//{
	//	count += i;
	//}
	for (int i = 1; i < length; i++)
	{
		if (length % i == 0)
		{
			count += i;
		}
	}
	return count;
}
int main()
{
	int a = solution(100);
	cout << a;
}