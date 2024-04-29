#define _USE_MATH_DEFINES
#include <iostream> 
#include <math.h>

//X=-44*π + sin(b) + cos(b) + tg(-a) - ctg(π*a) + π / (44*b+a) / (44*a-b)

using namespace std;
double calc(double a, double b)
{
	double result = 0;
	const int c44 = 44; 
	const int n = -1;

	__asm {

		fld a
		fimul n;
		fcos; cos(-a)

		fldpi
		fld a
		fsin; sin(pi*a)

		fld a
		fimul c44
		fsub b; 44a - b

		fld b
		fimul c44
		fadd a; 44b + a

		mov ecx, 4; 4 итерации цикла

			body :
		ftst; 
		fstp st(0); очищаем st0
		fstsw ax
		sahf
		je error; если да, то ошибка деления на ноль
		loop body

		fld b; st0 = b
		fsin; st0 = sinb

		fldpi; st0 = pi, st1 = sinb
		fimul c44; st0 = 44pi, st1 = sinb

		fsub; st0 = sinb - 44pi

		fld b; st0 = b, st1 = sinb - 44pi
		fcos; st0 = cosb, st1 = sinb - 44pi

		fadd; st0 = sinb - 44pi + cosb

		fld a; st0 = a, st1 = sinb - 44pi + cosb
		fimul n; st0 = -a, st1 = sinb - 44pi + cosb
		fsin; st0 = sin(-a), st1 = sinb - 44pi + cosb
		fld a; st0 = a, st1 = sin(-a), st2 = sinb - 44pi + cosb
		fimul n; st0 = -a, st1 = sin(-a), st2 = sinb - 44pi + cosb
		fcos; st0 = cos(-a), st1 = sin(-a), st2 = sinb - 44pi + cosb
		fdiv; st0 = tg(-a), st1 = sinb - 44pi + cosb
		fadd; st0 = sinb - 44pi + cosb + tg(-a)

		fldpi; st0 = pi, st1 = sinb - 44pi + cosb + tg(-a)
		fld a; st0 = a, st1 = pi, st2 = sinb - 44pi + cosb + tg(-a)
		fmul; st0 = pi*a, st1 = sinb - 44pi + cosb + tg(-a)
		fcos; st0 = cos(pi * a), st1 = sinb - 44pi + cosb + tg(-a)
		fldpi; st0 = pi, st1 = cos(pi * a), st2 = sinb - 44pi + cosb + tg(-a)
		fld a; st0 = a, st1 = pi, st2 = cos(pi * a), st3 = sinb - 44pi + cosb + tg(-a)
		fmul; st0 = pi * a, st1 = cos(pi * a), st2 = sinb - 44pi + cosb + tg(-a)
		fsin; st0 = sin(pi * a), st1 = cos(pi * a), st2 = sinb - 44pi + cosb + tg(-a)
		fdiv; st0 = ctg(pi * a), st1 = sinb - 44pi + cosb + tg(-a)
		fsub; st0 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)

		fldpi; st0 = pi, st1 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)
		fld b; st0 = b, st1 = pi, st2 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)
		fimul c44; st0 = 44b, st1 = pi, st2 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)
		fadd a; st0 = 44b - a, st1 = pi, st2 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)
		fdiv; st0 = pi / (44b+a), st1 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)
		fld a; st0 = a, st1 = pi / (44b + a), st1 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)
		fimul c44; st0 = 44a, st1 = pi / (44b + a), st1 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)
		fsub b; st0 = 44a-b, st1 = pi / (44b + a), st1 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)
		fdiv; st0 = pi / (44b + a) / (44a-b), st1 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a)

		fadd; st0 = sinb - 44pi + cosb + tg(-a) - ctg(pi * a) + pi / (44b + a) / (44a - b)

		jmp over

			error:
		fldz
			over:
		fstp result;
	}
	return result;
}

double calc_cpp(double a, double b) {
	if ((cos(-a) < 0.00001 && cos(-a) > -0.00001) || (sin(M_PI * a) < 0.00001 && sin(M_PI * a) > -0.00001) || (44 * b + a) == 0 || (44 * a - b) == 0)
	{
		cout << "Деление на 0" << endl;
		return 0;
	}
	return (sin(b) - (44 * M_PI) + cos(b) + tan(-a) - (1 / (tan(M_PI * a))) + ((M_PI / (44 * b + a)) / (44 * a - b)));
}

int main(int argc)
{
	setlocale(LC_ALL, "rus");
	cout << "Лабораторная работа No4, вариант 44. Выполнил ученик группы 6102-020302D Москалев Андрей." << endl;
	double a, b;
	cout << " a = ";
	cin >> a;
	cout << " b = ";
	cin >> b;
	
	if (calc_cpp(a, b) != 0) {
		cout << "Результат C++: " << calc_cpp(a, b) << endl;
		cout << "Результат ASM: " << calc(a, b) << endl;
	}
	system("PAUSE");
	return 0;
}