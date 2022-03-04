//#include <iostream>
//
//using namespace std;
//
//int solution()
//{
//	return;
//}
//
//
//int main()
//{
//}
#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string>
#include <ctime>
#include <sstream>

using namespace std;

int solution(string a)
{

	time_t temp;
	struct tm* timeinfo;

	time(&temp);
	timeinfo = localtime(&temp);

	int com = timeinfo->tm_year +1900;

	string c = a.substr(0, 2);
	int data=stoi(c);
	data += 1900;
	com -= data;
	stringstream scs;
	string b = to_string(com);

	string sex = a.substr(10, 1);
	if (sex=="1")
	{
		cout << "man";
	}
	if (sex == "2") 
	{
		cout << "woman";
	}
	return stoi(b);
}


int main()
{
	int data2 = solution("941119-1037929");
	cout << data2;
}
