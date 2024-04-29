#define _USE_MATH_DEFINES
#include <iostream> 
#include <math.h>

//x^(4/3) + (ln(x+8) + (x+8)*e^(-x) + 6^(x-8) + (x+8)*cos(x+8))^0.5 + 1/(5^cos(y/2)) + 1/(e^sin(y/2)) + e^(-y/2) + ln(y/2)^-1 + sec(y)

using namespace std;
double calc(double x, double y)
{
	double result = 0;
	const int c8 = 8;
	const int c4 = 4;
	const int c3 = 3;
	const int c6 = 6;
	const int c2 = 2;
	const int c1 = 1;
	const int c5 = 5;
	const int n = -1;

	__asm {
		; ln(y)						y > 0
		fld y

		;sec(y) = 1 / cos(y)		cos(y) != 0
		fld y
		fcos

		;ln(x + 8)					x + 8 > 0
		fld x
		fiadd c8

		mov ecx, 3;

	body:
		ftst;
		fstp st;
		fstsw ax;
		sahf;
		je error;
		loop body;
		;--------------------------------
		;x^4/3
		;--------------------------------
		fild c4;		st0 = 4
		fidiv c3;		st0 = 4 / 3
		fld x;			st0 = x								st1 = 4 / 3
		fyl2x;			st0 = 4/3*log2(x)
		fld st;			st0 = log2(x ^ (4 / 3))				st1 = log2(x ^ (4 / 3))
		frndint;		st0 = [log2(x ^ (4 / 3))]			st1 = log2(x ^ (4 / 3))
		fsub st(1), st; st0 = [log2(x ^ (4 / 3))]			st1 = {log2(x ^ (4 / 3))}
		fxch st(1);		st0 = { log2(x ^ (4 / 3)) }			st1 = [log2(x ^ (4 / 3))]
		f2xm1;			st0 = 2 ^ {log2(x ^ (4 / 3))} - 1
		fiadd c1;		st0 = 2 ^ {log2(x ^ (4 / 3))}		st1 = [log2(x ^ (4 / 3))]
		fscale;			st0 = x ^ (4 / 3)		
		fxch;
		fstp st;

		;-------------------------------
		; (ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8)) ^ 0.5
		;-------------------------------
		; ln(x + 8)
		fldln2;			st0 = ln2							
		fld x;			st0 = x								st1 = ln2
		fiadd c8;		st0 = x+8							st1 = ln2
		fyl2x;			st0 = ln2*log2(x+8)=ln(x+8)

		;(x+8)*e^(-x)
		fld x;			st0 = x								st1 = ln(x+8)
		fldl2e;			st0 = log2(e)						st1 = x					st2 = ln(x+8)
		fmul;			st0 = x*log2(e)
		fld st;			st0 = x * log2(e)					st1 = x * log2(e)
		frndint;		st0 = [x * log2(e)]					st1 = x * log2(e)
		fsub st(1), st; st0 = [x * log2(e)]					st1 = {x * log2(e)}
		fxch st(1);		st0 = { x * log2(e) }				st1 = [x * log2(e)]
		f2xm1;			st0 = 2 ^ {log2(e ^ (x))} - 1		st1 = [x * log2(e)]
		fiadd c1;		st0 = 2 ^ {log2(e ^ (x))}			st1 = [x * log2(e)]
		fscale;			st0 = e^(x)							st1 = ln(x+8)
		fidivr c1;		st0 = e^(-x)						st1 = ln(x+8)
		fxch;
		fstp st;
		fld x;			st0 = x								st1 = e^(-x)
		fiadd c8;		st0 = x	+ 8							st1 = e ^ (-x)
		fmul;			st0 = (x+8)*e^(-x)					st1 = ln(x+8)
		fadd;			st0 = ln(x + 8) + (x + 8) * e ^ (-x)

		; 6 ^ (x - 8)
		fld x;			st0 = x
		fisub c8;		st0 = x-8
		fild c6;			st0 = 6								st1 = x-8
		fyl2x;			st0 = (x-8)*log2(6)
		fld st;			st0 = (x - 8) * log2(6)				st1 = (x - 8) * log2(6)
		frndint;		st0 = [(x - 8) * log2(6)]			st1 = (x - 8) * log2(6)
		fsub st(1), st; st0 = [(x - 8) * log2(6)]			st1 = { (x - 8) * log2(6) }
		fxch st(1);		st0 = { (x - 8) * log2(6) }			st1 = [(x - 8) * log2(6)]
		f2xm1;			st0 = 2 ^ {log(6^(x-8))} - 1		st1 = [(x - 8) * log2(6)]
		fiadd c1;		st0 = 2 ^ {log(6 ^ (x - 8))}		st1 = [(x - 8) * log2(6)]
		fscale;			st0 = 6 ^ (x - 8)					st1 = ln(x + 8) + (x + 8) * e ^ (-x)
		fxch;
		fstp st;
		fadd;			st0 = ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8)

		; (x + 8)* cos(x + 8)
		fld x;			st0 = x
		fiadd c8;		st0 = x + 8
		fld st;			st0 = x + 8							st1 = x + 8
		fcos;			st0 = cos(x+8)						st1 = x + 8
		fmul;			st0 = (x+8)*cos(x+8)
		fadd;			st0 = ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8)

		;^0,5
		fsqrt;			st0 = (ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8))^0,5
		fadd;			st0 = x ^ (4 / 3) + (ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8)) ^ 0, 5
		
		;-------------------------------
		; 1 / (e ^ sin(y / 2))
		;-------------------------------
		fld y;			st0 = y
		fidiv c2;       st0 = (y/2)
		fsin;			st0 = sin(y/2)
		fldl2e;			st0 = log2(e)						st1 = sin(y/2)
		fmul;			st0 = sin(y/2) * log2(e)
		fld st;			st0 = sin(y / 2) * log2(e)			st1 = sin(y / 2) * log2(e)
		frndint;		st0 = [sin(y / 2) * log2(e)]		st1 = sin(y / 2) * log2(e)
		fsub st(1), st; st0 = [sin(y / 2) * log2(e)]		st1 = { sin(y / 2) * log2(e) }
		fxch st(1);		st0 = { sin(y / 2) * log2(e) }		st1 = [sin(y / 2) * log2(e)]
		f2xm1;			st0 = 2 ^ {log2(e ^ (sin(y/2)))}-1	st1 = [sin(y / 2) * log2(e)]
		fiadd c1;		st0 = 2 ^ {log2(e ^ (sin(y/2)))}	st1 = [sin(y / 2) * log2(e)]
		fscale;			st0 = e ^ (sin(y/2))				st1 = e ^ (sin(y / 2))
		fxch;
		fstp st;
		fidivr c1;		st0 = 1/(e ^ (sin(y / 2)))
		fadd;			st0 = x ^ (4 / 3) + (ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8)) ^ 0, 5 + 1 / (e ^ (sin(y / 2)))

		;-------------------------------
		; e ^ (-y / 2)
		;-------------------------------
		fld y;			st0 = y
		fimul n;			st0 = -y
		fidiv c2;		st0 = (- y / 2)
		fldl2e;			st0 = log2(e)						st1 = (- y / 2)
		fmul;			st0 = (-y / 2) * log2(e)
		fld st;			st0 = (-y / 2) * log2(e)			st1 = (-y / 2) * log2(e)
		frndint;		st0 = [(-y / 2) * log2(e)]			st1 = (-y / 2) * log2(e)
		fsub st(1), st; st0 = [(-y / 2) * log2(e)]			st1 = { (-y / 2) * log2(e) }
		fxch st(1);		st0 = { (-y / 2) * log2(e) }		st1 = [(-y / 2) * log2(e)]
		f2xm1;			st0 = 2 ^ {log2(e ^ (-y / 2))}-1	st1 = [(-y / 2) * log2(e)]
		fiadd c1;		st0 = 2 ^ {log2(e ^ (-y / 2))}		st1 = [(-y / 2) * log2(e)]
		fscale;			st0 = e ^ (-y / 2)
		fxch;
		fstp st;
		fadd;			st0 = x ^ (4 / 3) + (ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8)) ^ 0, 5 + 1 / (e ^ (sin(y / 2))) + e ^ (-y / 2)

		;--------------------------------
		;ln(y / 2) ^ -1 = ln(2/y)
		;--------------------------------
		fldln2;			st0 = ln2
		fild c2;		st0 = 2;							st1 = ln2
		fld y;			st0 = y								st1 = ln2
		fdiv;			st0 = (2/y)							st1 = ln2
		fyl2x;			st0 = ln2*log2(2/y)=ln(2/y)
		fadd;			st0 = x ^ (4 / 3) + (ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8)) ^ 0, 5 + 1 / (e ^ (sin(y / 2))) + e ^ (-y / 2) + ln(2 / y)
		
		;--------------------------------
		; sec(y)
		;--------------------------------
		fild c1;			st0 = 1
		fld y;			st0 = y
		fcos;			st0 = cos(y)
		fdiv;			st0 = 1/cos(y) = sec(y)
		fadd;			st0 = x ^ (4 / 3) + (ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8)) ^ 0, 5 + 1 / (e ^ (sin(y / 2))) + e ^ (-y / 2) + ln(2 / y) + sec(y)
		
		;--------------------------------
		; 1 / (5 ^ cos(y / 2))
		;--------------------------------
		fld y;			st0 = y								st1 = 1
		fidiv c2;		st0 = y/2							st1 = 1
		fcos;			st0 = cos(y/2)						st1 = 1
		fild c5;		st0 = 5								st1 = cos(y / 2)						
		fyl2x;			st0 = cos(y/2)*log2(5)				st1 = 1
		fld st;			st0 = cos(y / 2) * log2(5)			st1 = cos(y / 2) * log2(5)
		frndint;		st0 = [cos(y / 2) * log2(5)]		st1 = cos(y / 2) * log2(5)
		fsub st(1), st; st0 = [cos(y / 2) * log2(5)]		st1 = { cos(y / 2) * log2(5) }
		fxch st(1);		st0 = { cos(y / 2) * log2(5) }		st1 = [cos(y / 2) * log2(5)]
		f2xm1;			st0 = 2 ^ {log(5 ^ cos(y/2))} - 1	st1 = [cos(y / 2) * log2(5)]
		fiadd c1;		st0 = 2 ^ {log(5 ^ cos(y / 2))}		st1 = [cos(y / 2) * log2(5)]
		fscale;			st0 = 5 ^ cos(y / 2)				st1 = 1
		fxch;
		fstp st;
		fidivr c1;			st0 = 1/ 5 ^ cos(y / 2)
		fadd;			st0 = x ^ (4 / 3) + (ln(x + 8) + (x + 8) * e ^ (-x) + 6 ^ (x - 8) + (x + 8) * cos(x + 8)) ^ 0, 5 + 1 / (e ^ (sin(y / 2))) + e ^ (-y / 2) + ln(2 / y) + sec(y) + 1 / 5 ^ cos(y / 2)

		jmp over
	
	error:
		fldz

	over:
		fstp result
	}
	return result;
}

double calc_cpp(double x, double y) {
	if ((cos(y) < 0.00001 && cos(y) > -0.00001) || y<=0 || x<=-8 || (log(x + 8) + ((x + 8) * pow(M_E, -1 * x)) + pow(6, x - 8) + ((x + 8) * cos(x + 8))) < 0)
	{
		cout<<"Нет ";
		return 0;
	}
	return (pow(x,4.0/3.0) + sqrt(log(x+8) + ((x+8)* pow(M_E, ( - 1 * x))) + pow(6, x - 8) + ((x + 8) * cos(x + 8))) + (1 / (pow(M_E, sin(y / 2)))) + pow(M_E, (-1 * (y / 2))) + log(2 / y) + (1 / (cos(y))) + (1 / (pow(5, cos(y / 2)))));
}

int main(int argc)
{
	setlocale(LC_ALL, "rus");
	cout << "Лабораторная работа No5, вариант 52(2). Выполнил ученик группы 6102-020302D Москалев Андрей." << endl;
	cout <<	"Вычислить x^(4/3) + (ln(x+8) + (x+8)*e^(-x) + 6^(x-8) + (x+8)*cos(x+8))^0.5 + 1/(5^cos(y/2)) + 1/(e^sin(y/2)) + e^(-y/2) + ln(y/2)^-1 + sec(y)" << endl;
	double x0, y0, x1, y1, hx, hy;

	cout << "Введите начальное значение x: ";	cin >> x0;
	cout << "Введите конечное значение x: ";	cin >> x1;
	cout << "Введите шаг для x: ";				cin >> hx;

	cout << "Введите начальное значение y: ";	cin >> y0;
	cout << "Введите конечное значение y: ";	cin >> y1;
	cout << "Введите шаг для y: ";				cin >> hy;

	cout << "ASM: \n";
	cout << "y \\ x" << "\t|\t";
	for (double i = x0; i <= x1; i += hx)
	{
		cout << i << "\t|\t";
	}
	cout << "\n";
	for (double i = y0; i <= y1; i += hy)
	{
		cout << i << "\t|\t";
		for (double j = x0; j <= x1; j += hx)
		{
			cout << calc(j, i) << "\t|\t";
		}
		cout << "\n";
	}

	cout << "CPP: \n";
	cout << "y \\ x" << "\t|\t";
	for (double i = x0; i <= x1; i += hx)
	{
		cout << i << "\t|\t";
	}
	cout << "\n";
	for (double i = y0; i <= y1; i += hy)
	{
		cout << i << "\t|\t";
		for (double j = x0; j <= x1; j += hx)
		{
			cout << calc_cpp(j, i) << "\t|\t";
		}
		cout << "\n";
	}

	system("PAUSE");

	return 0;
}