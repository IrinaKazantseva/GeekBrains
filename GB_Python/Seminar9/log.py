from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
# from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes, CallbackContext

async def log(update: Update, context: ContextTypes.DEFAULT_TYPE):
    file = open("bd.csv", "a+")
    file.write(f'{update.effective_user.first_name}, {update.message.text}\n')
    file.close()


# def log(update: Update, context: CallbackContext):
#     file = open("bd.csv", "a", encoding = 'windows-1251')
#     file.write(f'{update.effective_user.first_name}, {update.message.text}\n')
#     file.close()