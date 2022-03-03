
#include <iostream>
#include <vector>
#include <algorithm>

#define MAX 100
#define MIN 2

using namespace std;

//N(2<=n<=100)���� ���̰� �Էµ˴ϴ�. �� N���� ��� �� ���� �������̰� ���� ���� ����
// �� ���ϱ��? �ִ� ���� ���̸� ����ϴ� ���α׷��� �ۼ��Ͻÿ�

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