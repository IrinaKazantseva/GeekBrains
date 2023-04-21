# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# Пример:
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

numbers = list(map(int, input("Введите числа через пробел: ").split()))
sum = 0
for i in range(1, len(numbers), 2):
    sum += numbers[i]
print(f"Сумма элементов на нечетных позициях = {sum}")


# my_list = [8, 5, 7, 3, 6]
# print(sum(my_list[1::2]))

# n = int(input())
# numbers = []
# comp = 0
# result = []
#
# numbers = [input() for i in range(n)]
# print(f'Изначальный список: {numbers}')
#
# result = list(map(lambda x: int(x) * int(numbers[-1 - int(numbers.index(x))]) if numbers[: int(len(numbers)/2)] else '', numbers))
# result = result[:int(len(result)/2)]
#
# if (len(numbers)%2 == 1):
# comp = int(numbers[int(n/2)]) * int(numbers[int(n/2)])
# result.append(comp)
#
# print(f'Результат: {result}')