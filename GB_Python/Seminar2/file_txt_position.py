# Задайте список из N элементов, заполненных числами из промежутка [-N, N].
# Найдите произведение элементов на указанных позициях.
# Позиции хранятся в файле file.txt в одной строке одно число.
# Реализуйте алгоритм перемешивания списка.
import random

# задаем список (верно для N - положительное число)
n = int(input("Введите число N: "))
numbers = list(range(-n, n+1))
print(f"Cписок: \n {numbers}")

#перемешиваем
random.shuffle(numbers)
print(f"Новый список: \n {numbers}")

# создаем файл для хранения позиций
#import random
with open('file.txt', 'w') as file:
    for i in range(n*2+1):
        file.write(f'{i}\n') # позиции в возрастающем порядке
        #file.write(f"{random.randrange(0, 2*n)}\n") # рандомное заполнение

# записываем позиции в список
with open('file.txt', 'r') as file:
    positions = list(map(int,file.readlines()))
#print(positions)

# указываем номера позиций
print(f"Диапазон позиций: от 0 до {n*2}")
position1 = positions[int(input("Введите позицию первого множителя: "))]
position2 = positions[int(input("Введите позицию второго множителя: "))]

# находим произведение элементов на указанных позициях
multiply = numbers[position1]*numbers[position2]

print(f'Значение множителя с индексом {position1} равно {numbers[position1]}. Значение множителя с индексом {position2} равно {numbers[position2]}. Их произведение = {multiply}')

# from random import randint
# n = int(input('Введите число N - '))
# numbers = []
# for i in range(n):
# numbers.append(randint(-n, n+1))
# print(numbers)
#
# f = open('file.txt', 'w')
# while True:
# s = input('Укажите позицию для вычисления - ')
# if s == "":
# break
# f.write(s+"\n")
# f.close()
#
# result = 1
# f = open('file.txt', 'r')
# for line in f:
# if line == "":
# break
# result *= numbers[int(line)]
# f.close()
# print(result)