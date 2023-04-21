# создать базу данных: поля "ID", "Имя", "Фамилия", "Телефон"

import random
import csv
import zlib


names = ["Ольга", "Елена", "Светлана", "Таисия", "Татьяна", "Егор", "Леонид", "Макар", "Захар", "Олег"]
surnames = ["Коваль", "Глушко", "Штирлиц", "Моисеенко", "Шифер", "Капестенко", "Миу", "Сан-Керне", "Опполо", "Кег"]

def phone_numbers():
    randomphone_numbers = random.randint(89000000000, 90000000000)
    return str(randomphone_numbers)

def notes():
    note = ""
    note = note + random.choice(names) + ',' + random.choice(surnames) + ',' + phone_numbers()
    return note

# Запись в csv
def start():
    with open('bd.csv', 'w', encoding = 'windows-1251') as file:
        string = "ID, Имя, Фамилия, Телефон\n"
        file.writelines(string)
        for i in range(10):
            a = f'{str(i + 1)},{notes()}\n'
            file.write(a)

# Запись в txt
# def start():
#     with open('bd.txt', 'w', encoding = 'windows-1251') as file:
#         string = "ID, Имя, Фамилия, Телефон\n"
#         file.writelines(string)
#         for i in range(10):
#             a = f'{str(i + 1)},{notes()}\n'
#             file.write(a)
#     # конвертация в csv
#     with open('bd.txt', 'r') as in_file:
#         lines = in_file.read().splitlines()
#         stripped = [line.replace(",", " ").split() for line in lines]
#         grouped = zip(*[stripped] * 1)
#         with open('bd.csv', 'w', newline='') as out_file:
#             writer = csv.writer(out_file)
#             for group in grouped:
#                 writer.writerows(group)


start()