# Задача 1:
# Стоимость строки

# Дана строка текста. Напишите программу для подсчета стоимости строки,
# исходя из того, что один любой символ (в том числе пробел) стоит
# 60 копеек. Ответ дайте в рублях и копейках в соответствии с примерами.

# Формат входных данных: На вход программе подается строка текста.

# Формат выходных данных: Программа должна вывести стоимость строки.

# Тестовые данные
# Sample Input 1:
# Привет, как дела?!
# Sample Output 1:
# 10 р. 80 коп.
# Sample Input 2:
# Тимур - лучший математик на свете!!
# Sample Output 2:
# 21 р. 0 коп.

# text = input("Введите строку: ")
# print(len(text))
# price_rub=int(len(text)*60/100)
# print(price_rub)
# price_kop=int(len(text)*60%100)
# print(price_kop)
# print(f"{price_rub} р. {price_kop} коп.")

#ИЛИ вместо инт (int) целочисленное деление (//):
# text = input("Введите строку: ")
# print(f"{(len(text)*60//100)} р. {(len(text)*60%100)} коп.")

#ИЛИ в одну строку:
# print(f'{(text:=(len(input("Введите строку: "))*60))//100} р. {text%100} коп.')

# Задача 2:
# Количество слов

# Дана строка, состоящая из слов, разделенных пробелами.
# Напишите программу, которая подсчитывает количество слов в этой строке.

# Формат входных данных
# На вход программе подается строка.

# Формат выходных данных
# Программа должна вывести количество слов в строке.

# Примечание 1. Кроме слов в тексте могут присутствовать только пробелы (один или несколько).

# Примечание 2. Решите задачу в одну строчку кода.

# Тестовые данные
# Sample Input 1:
# Hello world
# Sample Output 1:
# 2
# Sample Input 2:
# Timur forever young
# Sample Output 2:
# 3

#Решение через цикл:
# text = input("Введите строку: ")
# word=1
# for i in range(len(text)):
#     if(text[i] == " "):
#         word+=1
# print(word)

#Решение в 1 строку:
# print(len(input("Введите строку: ").split()))

#Задание 3:

# Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
# Пример:
# - Для N = 5: 1, -3, 9, -27, 81

# n = int(input("Введите число: "))
# num=-3
# for i in range(n):
#    print(num**i)

#Задание 4:
#Напишите программу, в которой пользователь будет задавать две строки,
# а программа - определять количество вхождений одной строки в другой.

text1 = input("Введите строку 1: ") # привет рад быть на семинаре
text2 = input("Введите строку2: ") # рад
print(text1.count(text2)) # 1









