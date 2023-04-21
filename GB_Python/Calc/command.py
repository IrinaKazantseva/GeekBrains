from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes, CallbackContext
from command import *
from log import *

async def hi_command(update: Update, context: CallbackContext):
    log(update, context)
    await update.message.reply_text(f'Hi, {update.effective_user.first_name}!')

async def help_command(update: Update, context: CallbackContext):
    log(update, context)
    await update.message.reply_text(f'/hello - приветствие\n/help - список доступных команд\n')
    await update.message.reply_text(f'Функции калькулятора:\nдля следующих операций введите два числа через пробел после команды\n')
    await update.message.reply_text(f'/sum - сложение\n/reduce - вычитание\n/multiply - умножение\n/divide - деление\n')

async def sum_command(update: Update, context: CallbackContext):
    log(update, context)
    msg = update.message.text
    items = msg.split()
    x = int(items[1])
    y = int(items[2])
    await update.message.reply_text(f'{x} + {y} = {x+y}')

async def reduce_command(update: Update, context: CallbackContext):
    log(update, context)
    msg = update.message.text
    items = msg.split()
    x = int(items[1])
    y = int(items[2])
    await update.message.reply_text(f'{x} - {y} = {x-y}')

async def multiply_command(update: Update, context: CallbackContext):
    log(update, context)
    msg = update.message.text
    items = msg.split()
    x = int(items[1])
    y = int(items[2])
    await update.message.reply_text(f'{x} * {y} = {x*y}')

async def divide_command(update: Update, context: CallbackContext):
    log(update, context)
    msg = update.message.text
    items = msg.split()
    x = int(items[1])
    y = int(items[2])
    if y != 0:
        await update.message.reply_text(f'{x} / {y} = {x/y}')
    else:
        await update.message.reply_text("На ноль делить нельзя!")