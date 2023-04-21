import csv

bd = []
global_id = 0

def init_data_base(file_name='bd.csv'):
    global global_id
    global bd
    global bd_file_name
    bd_file_name = file_name

    with open(bd_file_name, 'r', encoding = 'windows-1251') as csv_file:
        reader = csv.reader(csv_file)
        for row in reader:
            if (row[0] != 'ID'):
                bd.append(row)
                if (int(row[0]) > global_id):
                    global_id = int(row[0])

def create(name='', surname='', phonenumber=''):
    global global_id
    global bd
    global bd_file_name

    global_id += 1
    new_row = [str(global_id), name.title(),
               surname.title(), phonenumber]
    bd.append(new_row)
    with open(bd_file_name, 'a', newline='') as csv_file:
        writer = csv.writer(csv_file, delimiter=',',
                            quotechar='\'', quoting=csv.QUOTE_MINIMAL)
        writer.writerow(new_row)

def search(id='', name='', surname='', phonenumber=''):
    global global_id
    global bd
    global bd_file_name

    result = []
    for row in bd:
        if (id != '' and row[0] != id):
            continue
        if(name != '' and row[1] != name.title()):
            continue
        if(surname != '' and row[2] != surname.title()):
            continue
        if(phonenumber != '' and row[3] != phonenumber):
            continue
        result.append(row)
    if len(result) == 0:
        return f'Поиск провален'
    else:
        return result

def delete(id=''):
    global global_id
    global bd
    global bd_file_name

    for row in bd:
        if (row[0] == id):
            bd.remove(row)
            break

    with open(bd_file_name, 'w', newline='') as csv_file:
        writer = csv.writer(csv_file, delimiter=',',
                            quotechar='\'', quoting=csv.QUOTE_MINIMAL)
        for row in bd:
            writer.writerow(row)


