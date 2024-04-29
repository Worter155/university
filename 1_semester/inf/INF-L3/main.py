def information():
    print("Лабораторная работа №3")
    print("Вариант №11")
    print("Выполнил студент группы 6102-020302D Москалев Андрей")
    print("Задание:")
    print("В исходном текстовом файле записаны строки, содержащие произвольные алфавитно-цифровые символы.")
    print("Требуется написать программу, которая для каждой строки исходного файла будет печатать в результирующий файл")
    print("в алфавитном порядке только те буквы, которые встретились во входной последовательности ровно 3 раза.")
    print("Каждая буква при этом должна быть распечатана один раз. Буквы построенного слова должны быть прописными.")
    print()


def findSymbol(line):
    line = line.lower()
    Letters = {}
    s = "abcdefghijklmnopqrstuvwxyz"
    r = ''

    for i in line:
        if i in s:
            if i in Letters:
                Letters[i] += 1
            else:
                Letters[i] = 1

    for i in s:
        if Letters.get(i) == 3:
            r+=i
    return r



def task(f1,f2):
    file = f1.readlines()
    for line in file:
        if not findSymbol(line):
            f2.write('\n')
        else:
            f2.write(findSymbol(line)+"\n")



information()

fileName1 = input("Введите имя начального файла: ")
file1 = open(fileName1)
fileName2 = input("Введите имя конечного файла: ")
file2 = open(fileName2,'w')

task(file1,file2)
print("Готово")