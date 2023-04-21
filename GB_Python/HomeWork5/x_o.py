# Создайте программу для игры в ""Крестики-нолики"".

# создаем сетку
def board(listname):
    for row in listname:
        for elem in row:
            print(elem, end=' ')
        print()
# ход
def draw(numb, board, symb):
    if numb == 1:
        board[0][0] = symb
    elif numb ==2:
        board[0][1] = symb
    elif numb == 3:
        board[0][2] = symb
    elif numb ==4:
        board[1][0] = symb
    elif numb ==5:
        board[1][1] = symb
    elif numb ==6:
        board[1][2] = symb
    elif numb ==7:
        board[2][0] = symb
    elif numb ==8:
        board[2][1] = symb
    elif numb ==9:
        board[2][2] = symb
# условие выигрыша
def win(board):
    if board[0][0]==board[0][1]==board[0][2]:
        return True
    elif board[1][0]==board[1][1]==board[1][2]:
        return True
    elif board[2][0] == board[2][1] == board[2][2]:
        return True
    elif board[0][0] == board[1][0] == board[2][0]:
        return True
    elif board[0][1] == board[1][1] == board[2][1]:
        return True
    elif board[0][2] == board[1][2] == board[2][2]:
        return True
    elif board[0][0] == board[1][1] == board[2][2]:
        return True
    elif board[0][2] == board[1][1] == board[2][0]:
        return True

field = [['1', '2', '3'], ['4', '5', '6'], ['7', '8', '9']]
board(field)

player1 = input("Введите имя первого игрока: ")
player2 = input("Введите имя второго игрока: ")

import random
a = random.randint(0, 1)
if a:
    print(f"{player1} начинает и играет крестиками")
    b = True
    count = 0
    while not win(field) and count < 9:
        if b:
            n = int(input(f"{player1}, ход крестиков, выберите поле: "))
            draw(n, field, "x")
            count +=1
            b = False
            board(field)
        else:
            n = int(input(f"{player2}, ход ноликов, выберите поле: "))
            draw(n, field, "o")
            count += 1
            b = True
            board(field)
    else:
        if b == False:
            print("Крестики победили")
        else:
            print("Нолики победили")
else:
    print(f"{player2} начинает и играет крестиками")
    b = False
    count = 0
    while not win(field) and count < 9:
        if b:
            n = int(input(f"{player1}, ход ноликов, выберите поле: "))
            draw(n, field, "o")
            count += 1
            b = False
            board(field)
        else:
            n = int(input(f"{player2}, ход крестиков, выберите поле: "))
            draw(n, field, "x")
            count += 1
            b = True
            board(field)
    else:
        if b == True:
            print("Крестики победили")
        else:
            print("Нолики победили")
if count == 9:
    print("Ничья")
