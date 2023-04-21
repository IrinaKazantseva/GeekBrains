# Проверка на нечетность

from isOdd import isOdd

print(isOdd(3))
print(isOdd(5))

# Прогресс-бар

from progress.bar import Bar

bar = Bar('Processing', max=20)
for i in range(20):
    # Do some work
    bar.next()
bar.finish()