# Задайте натуральное число N. 
# Напишите программу, которая составит список простых множителей числа N.
#
# Вариант 1
#
# n = int(input("Введите натуральное число N: "))
# list = []
# i = 2
# while i <= n:
#     if n % i == 0:
#         list.append(i)
#         n //= i
#         i = 2
#     else:
#         i += 1
# print(f"Список простых множителей: {list}")
#
# Вариант 2
#
n = int(input("Введите натуральное число N: "))
list = []
i = 2
while i * i <= n:
    if n % i == 0:
        list.append(i)
        n //= i
    else:
        i += 1
if n > 1:
   list.append(n)
print(f"Список простых множителей: {list}")
