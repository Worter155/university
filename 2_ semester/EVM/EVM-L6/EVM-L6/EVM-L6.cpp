#define _USE_MATH_DEFINES
#include <iostream> 
#include <math.h>

//((3n-2)(x-3)^n)/(2^(n+1)(n+1)^2)

using namespace std;
double calc(double x, double eps, int N)
{
	double result = 0;
	const int c3 = 3;
	const int c2 = 2;
	const int c1 = 1;
	int n = 0;

	__asm {
		fldz; st0 = 0
		mov ebx, n; ebx = n

		body :
		; ----------------------------------------------------------------------------------------
			; 3n - 2
			; ----------------------------------------------------------------------------------------
			fild n;				st0 = n
			fimul c3;			st0 = 3n
			fisub c2;			st0 = 3n - 2
			; ----------------------------------------------------------------------------------------
			; *(x - 3) ^ n
			; ----------------------------------------------------------------------------------------
			fild n;				st0 = n
			fld x;				st0 = x
			fisub c3;			st0 = x - 3
			fyl2x;				st0 = log2((x - 3) ^ n)
			fld st;				st0 = log2((x - 3) ^ n)				st1 = log2((x - 3) ^ n)
			frndint;			st0 = [log2((x - 3) ^ n)]			st1 = log2((x - 3) ^ n)
			fxch;				st0 = log2((x - 3) ^ n)				st1 = [log2((x - 3) ^ n)]
			fsub st, st(1);		st0 = { log2((x - 3) ^ n) }			st1 = [log2((x - 3) ^ n)]
			f2xm1;				st0 = 2 ^ {log2((x - 3) ^ n)} - 1	st1 = [log2((x - 3) ^ n)]
			fiadd c1;			st0 = 2 ^ {log2((x - 3) ^ n)}		st1 = [log2((x - 3) ^ n)]
			fscale;				st0 = (x - 3) ^ n
			fxch
			fstp st
			fmul
			; ----------------------------------------------------------------------------------------
			; 2 ^ (n + 1)
			; ----------------------------------------------------------------------------------------
			fild n;				st0 = n
			fiadd c1;			st0 = n + 1
			fld1;
		fscale;
		fxch;
		fstp st;
		; ----------------------------------------------------------------------------------------
			; (n + 1) ^ 2
			; ----------------------------------------------------------------------------------------
			fild c2;			st0 = 2
			fild n;				st0 = n								st1 = 2
			fiadd c1;			st0 = n + 1							st1 = 2
			fyl2x;				st0 = log2((n + 1) ^ 2)
			fld st;				st0 = log2((n + 1) ^ 2)				st1 = log2((n + 1) ^ 2)
			frndint;			st0 = [log2((n + 1) ^ 2)]			st1 = log2((n + 1) ^ 2)
			fxch;				st0 = log2((n + 1) ^ 2)				st1 = [log2((n + 1) ^ 2)]
			fsub st, st(1);		st0 = { log2((n + 1) ^ 2) }			st1 = [log2((n + 1) ^ 2)]
			f2xm1;				st0 = 2 ^ {log2((n + 1) ^ 2)} - 1	st1 = [log2((n + 1) ^ 2)]
			fiadd c1;			st0 = 2 ^ {log2((n + 1) ^ 2)}		st1 = [log2((n + 1) ^ 2)]
			fscale;				st0 = (n + 1) ^ 2
			fxch
			fstp st
			fmul;
		fdiv;

		cmp ebx, 0; если это первая итерация, приступаем к следующей
			je counter; потому что нам нужны 2 значения: S(n) и S(n + 1)
			; ----------------------------------------------------------------------------------------
			;					st0 = S(n + 1)						st1 = S(n)				st2 = S(n - 1) + ... + S(0)
			fld st;				st0 = S(n + 1)						st1 = S(n + 1)			st2 = S(n)							st3 = S(n - 1) + ... + S(0)
			fsub st, st(2);		st0 = S(n + 1) - S(n)				st1 = S(n + 1)			st2 = S(n)							st3 = S(n - 1) + ... + S(0)
			fxch st(2);			st0 = S(n)							st1 = S(n + 1)			st2 = S(n + 1) - S(n)				st3 =
			faddp st(3), st;	st0 = S(n + 1)						st1 = S(n + 1) - S(n)	st2 = S(n) + S(n - 1) + ... + S(0)
			fxch;				st0 = S(n + 1) - S(n)				st1 = S(n + 1)			st2 = S
			fabs;				st0 = | S(n + 1) - S(n) | st1 = S(n + 1)			st2 = S
			fild eps
			fcomip st, st(1); если eps > | S(n + 1) - S(n) | , то == 0
			fstp st
			jne counter; если | S(n + 1) - S(n) | > eps, то продолжаем цикл
			jmp epsil; иначе конец

			counter :
		inc ebx; ebx += 1
			mov n, ebx; n = ebx		n += 1
			cmp ebx, N; ebx = ? N
			jne body; если нет, то тело цикла
			fadd
			jmp over

			epsil :
		fstp st
			over :
		fstp result
	}
	return result;
}

double calc_cpp(double x, double e, double N) {
	double a;
	double s = 0;
	int n = 0;
	do
	{
		a = ((3 * n - 2) * pow((x - 3), n)) / (pow(2, n + 1) * pow(n + 1, 2));
		s += a;
		n++;
	} while (abs(a) > abs(e) && n < N);
	cout << n << endl;
	return s;
}

int main(int argc)
{
	setlocale(LC_ALL, "rus");
	cout << "Лабораторная работа No6, вариант 52. Выполнил ученик группы 6102-020302D Москалев Андрей." << endl;
	cout << "Вычислить сумму ряда ((3n-2)(x-3)^n)/(2^(n+1)(n+1)^2)" << endl;
	double x, e, N;

	cout << "Введите x: "; cin >> x;
	cout << "Введите погрешность: "; cin >> e;
	cout << "Введите количество слагаемых: "; cin >> N;

	cout << calc(x, e, N) << endl;
	cout << calc_cpp(x, e, N) << endl;
	system("PAUSE");

	return 0;
}