# Вычислить число c заданной точностью d
# Пример:
# - при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$

from math import pi
d = int(input("Задайте точность числа Пи: "))
print(f'Число Пи равно {round(pi, d)}')

# import math
# d = input('Введите число d указывающее степень округления числа pi ')
# d = d[2:len(d)]
# print(round(math.pi,len(d)))

# a = int(input('введите нужную точность 1#= '))
# pi_target = 0
# for i in range(1, 1000000):
# pi_target += 4 * ((-1) ** (i + 1)) / (2 * i - 1)
# print(str(pi_target)[:a + 2])

# number = float(input())
# d = list('0.001')
# d.reverse()
# h = d.index('.')
# print(h)
# print(round(number, h))