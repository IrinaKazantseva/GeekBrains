import csv
import json
from pathlib import Path
from view import (get_employee, get_changes, get_id, get_first_name, get_last_name, show_search_menu,
                  get_phone_number, get_position, get_salary, get_salary_range, no_employee_error)

# fields = ["id", "last_name", "first_name", "position", "phone_number", "salary"]


def read_csv() -> list:
    employee = []
    with open(Path.cwd() / 'database.csv', 'r', encoding='utf-8') as fin:
        csv_reader = csv.reader(fin)
        for row in csv_reader:
            temp = {}
            temp["id"] = int(row[0])
            temp["last_name"] = row[1]
            temp["first_name"] = row[2]
            temp["position"] = row[3]
            temp["phone_number"] = row[4]
            temp["salary"] = float(row[5])
            employee.append(temp)
    return employee


def read_json() -> list:
    employee = []
    with open(Path.cwd() / 'database02.json', 'r', encoding='utf-8') as fin:
        for line in fin:
            temp = json.loads(line.strip())
            employee.append(temp)
    return employee


def write_csv(employees: list):
    with open(Path.cwd() / 'database.csv', 'w', encoding='utf-8') as fout:
        csv_writer = csv.writer(fout, lineterminator="\r")
        for employee in employees:
            csv_writer.writerow(employee.values())


def write_json(employees: list):
    with open(Path.cwd() / 'database02.json', 'w', encoding='utf-8') as fout:
        for employee in employees:
            fout.write(json.dumps(employee) + '\n')


def find_employee_by_id(employees: list, id: int) -> dict:
    for employee in employees:
        if employee['id'] == id:
            return employee
    return None


def find_employee_by_last_name(employees: list, last_name: str) -> dict:
    for employee in employees:
        if employee['last_name'] == last_name:
            return employee
    return None


def find_employee_by_phone_number(employees: list, phone_number: str) -> dict:
    for employee in employees:
        if employee['phone_number'] == phone_number:
            return employee
    return None


def find_employees_by_salary_range(employees: list) -> list:
    result = []
    lo, hi = get_salary_range()
    for employee in employees:
        if lo <= employee["salary"] <= hi:
            result.append(employee)
    return result


def find_employee_by_position(employees: list, position: str) -> list:
    result = []
    for employee in employees:
        if position in employee['position']:
            result.append(employee)
    return result


def update_employee(employees: list, employee: dict):
    idx = get_changes()
    if idx == 1:
        employee["id"] = get_id()
    elif idx == 2:
        employee["last_name"] = get_last_name()
    elif idx == 3:
        employee["first_name"] = get_first_name()
    elif idx == 4:
        employee["position"] = get_position()
    elif idx == 5:
        employee["phone_number"] = get_phone_number()
    elif idx == 6:
        employee["salary"] = get_salary()
    else:
        print("Вы ввели неверный индекс")


def add_employee(employees: list):
    employee = get_employee()
    employees.append(employee)


def del_employee(employees: list, employee: dict):
    employees.remove(employee)


def find_employee(employees: list) -> dict:
    search_choice = show_search_menu()
    if search_choice == 1:
        id = get_id()
        employee = find_employee_by_id(employees, id)
        if employee is not None:
            return employee
    elif search_choice == 2:
        last_name = get_last_name()
        employee = find_employee_by_last_name(employees, last_name)
        if employee is not None:
            return employee
    elif search_choice == 3:
        phone_number = get_phone_number()
        employee = find_employee_by_phone_number(employees, phone_number)
        if employee is not None:
            return employee
    else:
        return None
