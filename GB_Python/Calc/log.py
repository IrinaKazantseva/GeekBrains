from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes, CallbackContext


def log(update: Update, context: CallbackContext):
    file = open("log.csv", "a", encoding = 'windows-1251')
    file.write(f'{update.effective_user.first_name}, {update.message.text}\n')
    file.close()