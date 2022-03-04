#include <iostream>
#include <string>
using namespace std;

int solution(string a)
{
	int data=0;
	int result = 0;
	char count[100];
	strcpy(count, a.c_str());
	for (int i = 0; i !='\0'; i++)
	{
		if (count[i]<=57&&count[i]>=48)
		{
			data = data * 10 + (a[i] - 48);
		}
	}
	for (int j = 1; j <= data; j++)
	{
		if (data % j == 0)result++;
	}
	return result;
}


int main()
{
	solution("0a2xswsa04asd");
}