#include <iostream> 

//(b*b/a+1) если a>b
//(a*2) если a=b
//((a-10)/(a-b)) если a<b
using namespace std;
int calc(int a, int b)
{
	int result = 0;
	__asm {
		mov ecx, a;
		mov ebx, b;
		cmp ecx, ebx;
		jg bigger;
		jl smaller;
		imul ecx, 2;
		mov eax, ecx;
		jmp endapp;

	bigger:
		mov eax, ebx;
		imul ebx;
		jo error;
		cmp ecx, 0;
		je error;
		cdq;
		idiv ecx;
		add eax, 1;
		jmp endapp;

	smaller:
		mov eax, ecx;
		sub eax, 10;
		sub ecx, ebx;
		cdq;
		idiv ecx;
		jmp endapp;
	error:
	endapp:
		mov result, eax;
	}
	return result;
}

int calc_cpp(int a, int b) {
	if (a > b) return (b * b / a + 1);
	else if (a == b) return (2 * a);
	else return ((a - 10) / (a - b));
}

int main(int argc)
{
	setlocale(LC_ALL, "rus");
	cout << "Лабораторная работа No2, вариант 44. Выполнил ученик группы 6102-020302D Москалев Андрей." << endl;
	int a, b;
	cout << " a = ";
	cin >> a;
	cout << " b = ";
	cin >> b;
	if (a>b && a==0) {
		cout << "Ошибка деления на 0" << endl;
	}
	else {
		int res = calc(a, b);
		int res_cpp = calc_cpp(a, b);
		cout << "Результат ассемблера: ";
		cout << res << endl;
		cout << "Результат c++: ";
		cout << res_cpp << endl;
		cout << endl;
	}
	system("PAUSE");
	return 0;
}