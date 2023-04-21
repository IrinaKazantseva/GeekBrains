# Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.
# Входные и выходные данные хранятся в отдельных текстовых файлах

# Создаем файл с исходной строкой
with open('original.txt', 'w') as file:
    file.write(input("Введите строку: "))

# Алгоритм сжатия, запись в новый файл
with open('original.txt', 'r') as data:
    origtext = data.read()
# count = 1
# compressed = ""
# for i in range(len(origtext)-1):
#     if origtext[i] == origtext[i+1]:
#         count += 1
#     else:
#         compressed = compressed + str(count) + origtext[i]
#         count = 1
# if count > 1 or (origtext[len(origtext)-2] != origtext[-1]):
#     compressed = compressed + str(count) + origtext[-1]

count = 1
compressed = ""
char1 = ""
for char in origtext:
    if char is not char1:
        if char1:
            compressed += str(count) + char1
        count = 1
        char1 = char
    else:
        count +=1
else:
    compressed += str(count) + char1

print(compressed)
with open('result.txt', 'w') as file:
    file.write(compressed)

# Алгоритм восстановления, запись в новый файл

with open('result.txt', 'r') as data:
    recompressedtext = data.read()
count = ""
recompressed = ""
for char in recompressedtext:
    if char.isdigit():
        count += char
    else:
        recompressed += char * int(count)
        count = ""
print(recompressed)
with open('result2.txt', 'w') as file:
    file.write(recompressed)


# def coding(txt):
# count = 1
# res = ''
# for i in range(len(txt)-1):
# if txt[i] == txt[i+1]:
# count += 1
# else:
# res = res + str(count) + txt[i]
# count = 1
# if count > 1 or (txt[len(txt)-2] != txt[-1]):
# res = res + str(count) + txt[-1]
# return res
#
# def decoding(txt):
# num = ''
# res = ''
# for i in range(len(txt)):
# if not txt[i].isalpha():
# num += txt[i]
# else:
# res = res + txt[i] * int(num)
# num = ''
# return res