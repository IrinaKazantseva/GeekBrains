# Создайте программу для игры с конфетами человек против человека.
# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга.
# Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет. 
# Все конфеты оппонента достаются сделавшему последний ход. 
# Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?
# a) Добавьте игру против бота
# b) Подумайте как наделить бота ""интеллектом""

# Игроки-люди:

# player1 = input("Введите имя первого игрока: ")
# player2 = input("Введите имя второго игрока: ")
# sweet = int(input("Введите количество конфет на столе: "))
#
# Жеребьевка
#
# import random
# a = random.randint(0, 1)
# if a:
#     print(f"Первый ходит {player1}")
# else:
#     print(f"Первый ходит {player2}")
#
# Сама игра
#
# while sweet > 28:
#     if a:
#         n = int(input(f"{player1}, введите количество конфет от 1 до 28: "))
#         sweet -= n
#         a = False
#         print(f"Осталось на столе конфет: {sweet}")
#     else:
#         n = int(input(f"{player2}, введите количество конфет от 1 до 28: "))
#         sweet -= n
#         a = True
#         print(f"Осталось на столе конфет: {sweet}")
# if a:
#     print(f"Выиграл {player1}")
# else:
#     print(f"Выиграл {player2}")

# Игра с ботом
#
# player1 = input("Введите имя первого игрока: ")
# player2 = "Бот"
# sweet = int(input("Введите количество конфет на столе: "))
#
# Жеребьевка
#
# import random
# a = random.randint(0, 1)
# if a:
#     print(f"Первый ходит {player1}")
# else:
#     print(f"Первый ходит {player2}")
#
# Сама игра
#
# while sweet > 28:
#     if a:
#         n = int(input(f"{player1}, введите количество конфет от 1 до 28: "))
#         sweet -= n
#         a = False
#         print(f"Осталось на столе конфет: {sweet}")
#     else:
#         n = random.randint(1, 28)
#         sweet -= n
#         a = True
#         print(f"{player2} взял {n} конфет. Осталось на столе конфет: {sweet}")
# if a:
#     print(f"Выиграл {player1}")
# else:
#     print(f"Выиграл {player2}")

# Умный бот

player1 = input("Введите имя первого игрока: ")
player2 = "Бот"
sweet = int(input("Введите количество конфет на столе: "))

# Жеребьевка

import random
a = random.randint(0, 1)
if a:
    print(f"Первый ходит {player1}")
else:
    print(f"Первый ходит {player2}")

# Сама игра

while sweet > 28:
    if a:
        n = int(input(f"{player1}, введите количество конфет от 1 до 28: "))
        sweet -= n
        a = False
        print(f"Осталось на столе конфет: {sweet}")
    else:
        n = sweet - sweet//29 * 29
        sweet -= n
        a = True
        print(f"{player2} взял {n} конфет. Осталось на столе конфет: {sweet}")
if a:
    print(f"Выиграл {player1}")
else:
    print(f"Выиграл {player2}")


# from random import randint
#
# a = int(input('Введите количество конфет'))
# hod = 0
# wins = {0: 'Игрок', 1: 'Бот'}
# while a > 0:
# if a <= 28:
# print(f'Выиграл {wins[hod]}')
# break
# if hod % 2 == 0:
# print('Ход Игрока')
# d = int(input('Введите количество конфет, которое хотите взять'))
# a -= d
# print(f'Осталось конфет: {a}')
# else:
# print('Ход Бота')
# d = a % 29
# a -= d
# print(f'Осталось конфет: {a}')
# hod = (hod + 1) % 2
