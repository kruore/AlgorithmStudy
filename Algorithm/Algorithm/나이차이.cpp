
#include <iostream>
#include <vector>
#include <algorithm>

#define MAX 100
#define MIN 2

using namespace std;

//N(2<=n<=100)명의 나이가 입력됩니다. 이 N명의 사람 중 가장 나이차이가 많이 나는 경우는
// 몇 살일까요? 최대 나이 차이를 출력하는 프로그램을 작성하시오

int solution(vector<int> m)
{
	
	int small=MAX, big = 0;

	for (int i = 1; i < m.size(); i++)
	{
		if (small > i) big = m[i];
		if (big < i)small = m[i];
	}
	return big - small;
}


int main()
{
	vector<int> a = { 1,2,3,4,5,6,7,8,9,100};
	int answer=solution(a);
	cout << answer;
}