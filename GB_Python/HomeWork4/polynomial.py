# Задана натуральная степень k. 
# Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена
# и записать в файл многочлен степени k.
# Пример:
# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0

import random
k = int(input("Задайте натуральную степень k = "))
koeflist = [random.randint(0, 101) for i in range(k+1)]

list = koeflist[::-1]
stroka=""
if len(list) < 1:
    stroka = 'x = 0'
else:
    for i in range(len(list)):
        if i != len(list) - 1 and list[i] != 0 and i != len(list) - 2:
            stroka += f'{list[i]}x^{len(list) - i - 1}'
            if list[i + 1] != 0:
                stroka += ' + '
        elif i == len(list) - 2 and list[i] != 0:
            stroka += f'{list[i]}x'
            if list[i + 1] != 0:
                stroka += ' + '
        elif i == len(list) - 1 and list[i] != 0:
            stroka += f'{list[i]} = 0'
        elif i == len(list) - 1 and list[i] == 0:
            stroka += ' = 0'
print(stroka)

# with open('polynom1.txt', 'w') as data:
#     data.write(stroka)
#
# Для следующей задачи:
with open('polynom2.txt', 'w') as data:
    data.write(stroka)


# from random import randint
#
# k = int(input('Insert equation power: '))
# koefs = list()
# for i in range(1, k + 2):
# koefs.append(randint(1, 100))
#
# ans = list()
# for i in range(len(koefs)):
# if k == 1:
# ans.append(f'{koefs[i]}*x')
# elif k == 0:
# ans.append(f'{koefs[i]}')
# else:
# ans.append(f'{koefs[i]}*x**{k}')
# flag = randint(0, 1)
# if flag == 1:
# ans.append('+')
# elif flag == 0:
# ans.append('-')
# k -= 1
#
# ans.pop(-1)
# ans.append('=0')
# fout = open('output.txt', 'w')
# fout.write(''.join(ans))
# fout.close()

# подключение библиотеки
# import random
# from numpy.polynomial import Polynomial as P
#
# p = P([0, 0, -2,])
#
# print(p)
#
# k = random.randint(1, 4)
# print(k)
# poly = p ** k
# print(poly)
#
# data = open('file04', 'w')
# data.write(str(poly))
# data.close()
#
# data = open('file04', 'r')
# print(*data)
# data.close()
