# Напишите программу, которая будет преобразовывать десятичное число в двоичное.
# Пример:
# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10
#
# decimal = int(input("Введите десятичное число: "))
# binar = ""
# while decimal > 0:
#     binar = str(decimal%2)+binar
#     decimal//=2
# print(binar)
#
a=int(input('Введите число = '))
print(bin(a)[2:])