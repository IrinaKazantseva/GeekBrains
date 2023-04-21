import base
import menu
import process_csv as pr_csv


# создает базу данных при первом использовании
# base.start()

pr_csv.init_data_base('bd.csv')
menu.menu1()