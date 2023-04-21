from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes, CallbackContext
from telegram import Update
from aiogram import Bot, Dispatcher, executor, types
from aiogram.types import ReplyKeyboardRemove, ReplyKeyboardMarkup, KeyboardButton


API_TOKEN = '5913695353:AAFUR4TxoYT6ROkk5K9h8B7whUa3OqfNiBQ'

bot = Bot(token=API_TOKEN)
dp = Dispatcher(bot)

@dp.message_handler(commands=['start'])
async def start(message: types.Message):
    markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
    item1=types.KeyboardButton("Калькулятор")
    item2=types.KeyboardButton("Выход")
    markup.add(item1)
    markup.add(item2)
    await message.reply("Привет! Выбери действие.\n", reply_markup=markup)


@dp.message_handler(content_types=["text"])
async def choice(message: types.Message):
    if message.text.strip() == 'Калькулятор':
        markup=types.ReplyKeyboardMarkup(resize_keyboard=True)
        item1=types.KeyboardButton("+")
        item2=types.KeyboardButton("-")
        item3=types.KeyboardButton("*")
        item4=types.KeyboardButton("/")
        item5=types.KeyboardButton("Выход")
        markup.add(item1)
        markup.add(item2)
        markup.add(item3)
        markup.add(item4)
        markup.add(item5)
        await message.reply("Выбери действие\n", reply_markup=markup)
    elif message.text.strip() == '+' or message.text.strip() == '-'or message.text.strip() == '*'or message.text.strip() == '/':
        await message.reply("Введите два числа через пробел")
    elif message.text.strip() == 'Выход':
        await message.reply("Ну и ладно!", reply_markup=types.ReplyKeyboardRemove())


if __name__ == '__main__':
   executor.start_polling(dp, skip_updates=True)
