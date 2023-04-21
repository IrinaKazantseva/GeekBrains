# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# - 6782 -> 23
# - 0,56 -> 11

number = float(input("Введите вещественное число: "))
sum = 0
for i in str(number):
    if (i != "."):
        sum += int(i)
print(sum)

# s = '0.56'
# summ = 0
# for i in s:
# if i.isdigit():
# summ += int(i)
# print(summ)

# n = float(input('Введите число - '))
# while n % 1 > 0:
# n *= 10
# summ = 0
# while n > 0:
# summ += n % 10
# n //= 10
# print(int(summ))

# from functools import reduce
#
# number = list(input('Введите вещественное число: '))
# sum_of_digits = 0
#
# number = list(filter(lambda x: x not in (',', '.'), number))
# print(f'Введенное число: {number}')
#
# sum_of_digits = reduce(lambda x, y: int(x) + int(y), number)
# print(f'Сумма цифр числа: {sum_of_digits}')


# number = float(input("Введите вещественное число: "))
# new_sum = sum(map(int, str(number).replace('.', '')))
# print(f"Сумма цифр вещественного числа равна = {new_sum}")