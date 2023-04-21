# Задайте список из n чисел последовательности (1+1/n)**n и выведите на экран их сумму.

n = int(input("Введите число N: "))
list=[]
for i in range(1, n+1):
      list.append(round((1+1/i)**i,3))
print(f'Для числа {n} сумма списка {list} = {sum(list)}')


# n = int(input())
# summ = 0
# for i in range(1, n + 1):
# summ += (1 + 1 / i) ** i
# print(summ)

# from functools import reduce
#
# n = int(input())
# numbers = [round((1+1/n)**n, 2) for n in range(1, n + 1)]
# print(f'Полученный список: {numbers}')
#
# sum = reduce(lambda x, y: int(x) + int(y), numbers)
# print(f'Сумма чисел списка: {sum}')