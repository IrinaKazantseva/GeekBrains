# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
# Пример:
# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

numbers = list(map(int, input("Введите числа через пробел: ").split()))
news = []
for index, new in enumerate(numbers):
    if index%2:
        news.append(new)
print(news)
print(sum(news))


# def sum_odd_index(lst: list) -> int:
# l = enumerate(lst)
# l1 = filter(lambda e: e[0] % 2 == 1, l)
# l2 = list(zip(*l1))
# l3 = list(l2[1])
# return sum(l3)
#
#
# print(sum_odd_index([2, 3, 5, 9, 3]))