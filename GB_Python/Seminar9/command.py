from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes 
# from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes, CallbackContext
# import datetime
from log import *

async def hi_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
# async def hi_command(update: Update, context: CallbackContext):
    await log(update, context)
    # log(update, context)
    await update.message.reply_text(f'Hi, {update.effective_user.first_name}!')

async def echo_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
# async def echo_command(update: Update, context: CallbackContext):
    await log(update, context)
    # log(update, context)
    msg = update.message.text
    await update.message.reply_text(f'{msg}')

# async def time_command(update: Update, context: CallbackContext):
    # log(update, context)
    # await update.message.reply_text(f'{datetime.datetime.now()}')


# async def help_command(update: Update, context: CallbackContext):
    # log(update, context)
    # await update.message.reply_text(f'/hello\n/time\n/help\n/sum\n/echo\n')


async def sum_command(update: Update, context: ContextTypes.DEFAULT_TYPE):
# async def sum_command(update: Update, context: CallbackContext):
    await log(update, context)
    # log(update, context)
    msg = update.message.text
    items = msg.split()
    x = int(items[1])
    y = int(items[2])
    await update.message.reply_text(f'{x} + {y} = {x+y}')