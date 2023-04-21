# Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
number = input("Задайте номер четверти: ")

coord = ['x > 0 and y > 0', 'x < 0 and y > 0', 'x < 0 and y < 0', 'x > 0 and y < 0']
quarter = ['1', '2', '3', '4']

data = list(zip(quarter, coord))

for i in range(4):
    if number in data[i][0]:
        print(data[i][1])
