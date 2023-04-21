# Задача 1.
# НОД (наибольший общий делитель)
# Решение 1.
# a = int(input('Первое число: '))
# b = int(input('Второе число: '))
# import math
# print("НОД двух чисел равен", math.gcd(a,b))

# Решение 2.
# a=20
# b=75
# while a != b:
#     if a > b:
#         a -= b
#     else:
#         b -= a
# print(a)

# Решение 3.
# a = int(input('Первое число: '))
# b = int(input('Второе число: '))
# if a < b :
#     a, b = b, a
# while b!=0:
#     a, b = b, a % b
# print(a)

# Задача 2.
# Объявите анонимную (лямбда) функцию для
# определения вхождения в переданную ей строку фрагмента "plr".
# То есть, функция должна возвращать True, если такой фрагмент присутствует в строке и
# False - в противном случае.
# Решение 1.
# print((lambda x: 'plr' in x)(input('Строка: ')))
# Решение 2.
# contains = lambda s, sample='ra': sample in s
# s = input()
# print(contains(s))
# Решение 3.
# x = input()
# y = "plr"
# search = lambda x,y: y in x
# print(search(x, y))

# Задача 3.
# Напишите программу, удаляющую из текста все слова, содержащие "абв".
# with open('file.txt', 'w') as data:
#      data.write(input('Строка: '))
# print()
# print('1.Задача: Удалить из текста все слова, содержащие ""абв""')
# with open('file.txt', 'r', encoding = 'windows-1251') as data:
#     stroka = data.read().split()
# print(f'В файле записано: {stroka}')
# print('Удалили все слова с абв и получили: ')
# print(' '.join([word for word in stroka if 'абв' not in word]))
# print()


# Задача 4.
# Создать текстовый файл, записать в него построчно данные,
# которые вводит пользователь. Окончанием ввода пусть служит пустая строка.

fname = input('Файл: ')
f = open(fname,'w')
while True:
    s = input()
    if s == '':
        break
    f.write(s+'\n')
f.close()