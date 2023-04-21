# Задайте список из вещественных чисел. Напишите программу, 
# которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
# Пример:
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19

numbers = list(map(float, input("Введите числа через пробел: ").split()))
newnumbers = []
for i in range(len(numbers)):
    if numbers[i] % 1 != 0:
        newnumbers.append(round(numbers[i]%1, 2))
print(f"Разница между максимальным и минимальным значением дробной части элементов списка = {max(newnumbers) - min(newnumbers)}")

# list = [1.1, 1.2, 3.1, 5, 10.01]
# min = 1
# max = 0
# for i in list:
# if (i % 1) <= min:
# min = i % 1
# if ( i % 1) >= max:
# max = i % 1
# print (f"Разница между максимальным и минимальным значением дробной части равна: {(max-min)}")


# from functools import reduce
#
# n = int(input())
# numbers = []
#
# numbers = [float(input()) for i in range(n)]
# print(f'Изначальный список: {numbers}')
#
# numbers = list(map(lambda x: round(float(x) - int(x), 2), numbers))
# print(f'Убираем целочисленную часть элементов: {numbers}')
#
# numbers = list(filter(lambda x: float(x) != 0.0, numbers))
# print(f'Список без элементов с нулевой дробной частью: {numbers}')
#
# max_number = reduce(lambda x, y: x if (x > y) else y, numbers)
# print(f'Максимальное значение: {max_number}')
#
# min_number = reduce(lambda x, y: x if (x < y) else y, numbers)
# print(f'Минимальное значение: {min_number}')
#
# result = max_number - min_number
# print(f'Разность максимального и минимального значений: {result}')