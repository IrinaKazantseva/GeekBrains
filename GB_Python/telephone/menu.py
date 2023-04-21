import process_csv as pr


def menu1():
    while True:
        print('\nМЕНЮ')
        print('1. Показать все записи.')
        print('2. Найти номер по фамилии.')
        print('3. Найти номер по имени.')
        print('4. Поиск по номеру телефона.')
        print('5. Добавить новую запись.')
        print('6. Удалить запись.')
        print('7. Выход.')

        n = int(input('Выберите пункт меню: '))

        if n == 1:
            print(pr.search())

        elif n == 2:
            choose = input('Введите фамилию: ')
            print(pr.search(surname=choose))

        elif n == 3:
            choose = input('Введите имя: ')
            print(pr.search(name=choose))

        elif n == 4:
            choose = input('Введите номер  телефона: ')
            print(pr.search(phonenumber=choose))

        elif n == 5:
            name = input('Введите имя: ')
            surname = input('Введите фамилию: ')
            phonenumber = input('Введите номер телефона: ')
            pr.create(name, surname, phonenumber)

        elif n == 6:
            print('1. Найти номер по фамилии.')
            print('2. Найти номер по имени.')
            print('3. Поиск по номеру телефона.')
            deleting = int(input('Введите номер пункта: '))
            if deleting == 1:
                choose = input('Введите фамилию: ')
                print(pr.search(surname=choose))
                user_id = input('Введите id записи: ')
                pr.delete(id=user_id)

            elif deleting == 2:
                choose = input('Введите имя: ')
                print(pr.search(name=choose))
                user_id = input('Введите id записи: ')
                pr.delete(id=user_id)

            elif deleting == 3:
                choose = input('Введите номер телефона: ')
                print(pr.search(phonenumber=choose))
                user_id = input('Введите id записи: ')
                pr.delete(id=user_id)

        elif n == 7:
            print('Спасибо!')
            break


