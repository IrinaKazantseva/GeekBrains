# Вводные сведения

#print("hello world") # string

#print(6) # integer

#a=b=10
#a=a+1
#print(b) #10

#a=int(input("Введите а "))
#if a%2==0:
    #print(True) # четное
#else:
    #print(False) # нечетное

# Задания

#1. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
#*Примеры:*
#- 5, 25 -> да
#- 4, 16 -> да
#- 25, 5 -> да
#- 8,9 -> нет

# Решение 1
#a=int(input("Введите первое число "))
#b=int(input("Введите второе число "))
#if b==a*a:
    #print("второе число - квадрат первого")
#elif a==b*b:
    #print("первое число - квадрат второго")
#else:
    #print("числа не квадраты друг друга")

#2. Напишите программу, которая на вход принимает 5 чисел и находит максимальное из них.

#Примеры:

#- 1, 4, 8, 7, 5 -> 8
#- 78, 55, 36, 90, 2 -> 90

# Решение 1

# a=int(input("Введите первое число "))
# b=int(input("Введите второе число "))
# c=int(input("Введите третье число "))
# d=int(input("Введите четвертое число "))
# e=int(input("Введите пятое число "))
# maks=a
# if b>maks:
#     maks=b
# if c > maks:
#     maks = c
# if d > maks:
#     maks = d
# if e > maks:
#     maks = e
# print("Максимальное число ", maks)

# Решение 2

# list_number = []
# for i in range(5):
# a=int(input())
# list_number.append(a)
# print(list_number)
# max=list_number[0]
# for i in range(len(list_number)):
# if list_number[i]>max:
# max=list_number[i]
# print(max)

# Решение 3

#numbers=[int(input("Введите первое число ")), int(input("Введите второе число ")), int(input("Введите третье число ")), int(input("Введите четвертое число ")), int(input("Введите пятое число "))]
# maks=numbers[0]
# for i in range(len(numbers)):
#     if numbers[i]>maks:
#         maks=numbers[i]
# print(maks)

# Решение 4

#numbers=[int(input("Введите первое число ")), int(input("Введите второе число ")), int(input("Введите третье число ")), int(input("Введите четвертое число ")), int(input("Введите пятое число "))]
#print(max(numbers))  # функция

# 3. Напишите программу, которая будет на вход принимать число N и выводить числа от -N до N
#
# *Примеры:*
#
# - 5 -> -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

# Решение 1
#
# n=int(input("Введите число N: "))
# numbers = []
# start = -n
# if n>0:
#     for i in range(n*2+1):
#         numbers.append(start)
#         start+=1
#     print(numbers)
# else:
#     for i in range(-n*2+1):
#         numbers.append(start)
#         start-=1
#     print(numbers)

# Решение 2

n = int(input("Введите число N: "))
numbers = list(range(-n, n+1)) #верно для положительных чисел
print(numbers)


# Решение 3

# n = int(input("Введите число N: "))
# m = -n
# if n>0:
#     while n >= m:
#         print(m)
#         m += 1
# else:
#     while n <= m:
#         print(m)
#         m -= 1

# 2. Напишите программу, которая будет принимать на вход дробь и показывать первую цифру дробной части числа.
#
# *Примеры:*
#
# - 6,78 -> 7
# - 5 -> нет
# - 0,34 -> 3

# n = abs(float(input('Введите число ')))
# if (n*10%10==0): #решение верно для дроби с целой частью меньше 10
#     print('нет дробной части')
# else:
#     print(int(n*10%10))