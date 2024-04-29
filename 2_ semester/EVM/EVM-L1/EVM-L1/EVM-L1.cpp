#include <iostream> 

// функция вычисления выражения (10*a+81-2*b*b)/(-2*c-32/d);
using namespace std;
int calc(int a, int b, int c, int d)
{
	int result = 0;
	__asm {
		mov eax, b
		mov ebx, a
		imul ebx, 10; ebx = 10 * a
		add ebx, 81; ebx = 10 * a + 81
		imul eax; eax = b * b
		imul eax, -2; eax = -2 * b * b
		add eax, ebx; eax = 10 * a + 81 - 2 * b * b
		push eax

		mov eax, -32
		mov ebx, d
		cdq
		idiv ebx; eax = -32 / d
		mov ebx, c
		imul ebx, -2
		add ebx, eax; ebx = -2 * c - 32 / d
		pop eax; eax = 10 * a + 81 - 2 * b * b
		cdq
		idiv ebx; eax = (10 * a + 81 - 2 * b * b) / (-2 * c - 32 / d)
		mov result, eax
	}
	return result;
}

int calc_cpp(int a, int b, int c, int d) {
	return (10 * a + 81 - 2 * b * b) / (-2 * c - 32 / d);
}

int main(int argc)
{
	setlocale(LC_ALL, "rus");
	cout << "Лабораторная работа No1, вариант 44. Выполнил ученик группы 6102-020302D Москалев Андрей." << endl;
	int a, b, c, d;
	cout << " a = ";
	cin >> a;
	cout << " b = ";
	cin >> b;
	cout << " c = ";
	cin >> c;
	cout << " d = ";
	cin >> d;
	if (d == 0 || (-2 * c - 32 / d) == 0) {
		cout << "Ошибка деления на 0" << endl;
	}
	else {
		int res = calc(a, b, c, d);
		int res_cpp = calc_cpp(a, b, c, d);
		cout << "Результат ассемблера: ";
		cout << res << endl;
		cout << "Результат c++: ";
		cout << res_cpp << endl;
		cout << endl;
	}
	system("PAUSE");
	return 0;
}