#include <iostream> 

/*В одномерном массиве A = {a[i]} целых чисел вычислить 
сумму элементов массива, удовлетворяющих условию :
b <= a[i] <= d.*/

using namespace std;
int calc(int b, int d, int s, int* mas)
{
	int result = 0;
	__asm {
		xor esi, esi; подготовим регистр индекса в массиве
		mov eax, 0; храним тут результат
		mov	ebx, mas; ebx указывает на начало массива
			mov	ecx, s; счётчик цикла по всем элементам массива
			jcxz	exit_1; завершить если длина массива 0
		begin_loop:
			mov	edi, [ebx + esi * 4]; определяем текущий элемент
			mov	edx, d; подготовка сравнения с d
			cmp	edi, edx;	сравнение a[i] и d
			jg	end_loop;	если больше, то завершаем цикл
			mov	edx, b; подготовка сравнения с b
			cmp	edi, edx;	сравнение a[i] и b
			jl	end_loop;	если меньше, то завершаем цикл
			add	eax, edi;	элемент удовлетворяет условию, прибавляем
		end_loop:
			inc	esi; переходим к следующему элементу
			loop begin_loop; повторяем цикл для всех элементов масиива
		exit_1: 
			mov	result, eax; возвращаем количество элементов

	}
	return result;
}

int calc_cpp(int b, int d, int size, int* mas) {
	int sum = 0;
	for (int i = 0; i < size; i++)
	{
		if (mas[i] <= d && mas[i] >= b) {
			sum += mas[i];
		}
	}
	return sum;
}

int main(int argc)
{
	setlocale(LC_ALL, "rus");
	cout << "Лабораторная работа No3, вариант 44. Выполнил ученик группы 6102-020302D Москалев Андрей." << endl;
	int b, d, size;
	cout << " b = ";
	cin >> b;
	cout << " d = ";
	cin >> d;
	cout << " size = ";
	cin >> size;
	int* mas = new int[size];
	cout << "Заполните массив" << endl;
	for (int i = 0; i < size; i++)
	{
		cout << i << " элемент: ";
		cin >> mas[i];
	}
	cout << "Результат C++: " << calc_cpp(b, d, size, mas) << endl;
	cout << "Результат ASM: " << calc(b, d, size, mas) << endl;
	system("PAUSE");
	return 0;
}