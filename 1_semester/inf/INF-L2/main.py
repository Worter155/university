from random import randint
def task():
    print("Лабораторная работа No 2")
    print("Вариант No 1. Выполнил студент группы 6102-020302D Москалев А.А.")
    print("Задание:")
    print("1. В списке целочисленных элементов найти")
    print(" минимальный четный положительный элемент")
    print("2. С использованием цикла while найти в списке")
    print(" индекс последнего нечетного элемента, некратного заданному числу")
    print("3. Отсортировать список (без использования стандартных")
    print(" функций сортировки) по возрастанию старших цифр элементов списка (сортировка Шелла)")
    print("")


def first_input():
     lst = [int(x) for x in input().split()]
     return lst


def second_input(n,a,b):
    lst=[]
    for i in range(n):
        lst.append(randint(a,b))
    return lst


def search(lst):
    m = 10**9
    for i in lst:
        if i%2==0 and i>0 and i<m:
            m = i
    return m


def index(lst, n):
    i = len(lst)-1
    while (lst[i]%2==0 or lst[i]%n==0) and i>-1:
        i-=1
    return i


def sorting(lst):
    interval = len(lst)//2
    while interval > 0:
        for i in range(interval,len(lst)):
            v = lst[i]
            j = i
            while j >= interval and int(str(abs(v))[0]) < int(str(abs(lst[j-interval]))[0]):
                lst[j] = lst[j-interval]
                j -= interval
            lst[j] = v
        interval //= 2
    return lst

task()
print("Введите способ заполнения списка:\n1-ввод элементов списка в одну строку через пробел\n"
      "2-автоматическое формирование списка из n элементов в заданном диапазоне")
n = int(input())
if n == 1:
    print("Введите список эллементов через пробел")
    lst = first_input()
else:
    print("Введите кол-во элелементов, минимальное и максимальное значение элемента")
    lst = second_input(int(input()), int(input()), int(input()))

print(lst)
print("Задание 1")
if search(lst) == 10 ** 9:
    print("В списке нет четного положительного числа")
else:
    print("Минимальный четный положительный элемент: ", search(lst))
print("")
print("Задание 2")
p = int(input("Введите число, которому не будет кратно искомое число "))
while p==0:
    print("На ноль делить нельзя")
    p = int(input("Введите число, которому не будет кратно искомое число "))
if index(lst, p) == -1:
    print("В списке нет нечетного элемента, некратного числу {}".format(p))
else:
    print("Индекс последнего нечетного элемента, некратного числу {}: ".format(p), index(lst, p))
print("")
print("Задание 3")
print("Исходный список:")
print(lst)
print("Отсортированный список:")
print( sorting(lst))
