# Задайте последовательность чисел. 
# Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.

# numbers = list(map(int, input("Введите последовательность чисел через пробел: ").split()))
# unique_numbers = []
# for number in numbers:
#     if number in unique_numbers:
#         continue
#     else:
#         unique_numbers.append(number)
# print(unique_numbers)

numbers = list(map(int, input("Введите числа через пробел:\n").split()))
print(numbers)
new_numbers = []
for i in numbers:
    if i not in new_numbers:
        new_numbers.append(i)
print(new_numbers)

# def elements(nums):
# nums = [int(i) for i in nums.split()]
# return list(set(nums))
# numbers = '1 1 2 2 3 455 66 66 2 1'
# print(elements(numbers))

# для другого типа задач!
# a= [1,2,2,2,2,3,1,4]
# print(set(a))

# b = [1, 1, 2, 3, 3, 4, 5]
# a = []
# for i in b:
# if b.count(i) == 1:
# a.append(i)
# print(a)

