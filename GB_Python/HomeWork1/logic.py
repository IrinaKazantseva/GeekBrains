# Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.
#Решение 1, вывод в виде списка
for x in [True,False]:
    for y in [True,False]:
        for z in [True,False]:
            print(f"Значение предикат: {x,y,z}")
            print(f"Истинность утверждения: {not(x or y or z) == (not x and not y and not z)}")

#Решение 2, вывод в виде таблички
print("x y z proof")
for x in range(2):
    for y in range(2):
        for z in range(2):
            proof = (not(x or y or z) == (not x and not y and not z))
            print(x, y, z, proof)

