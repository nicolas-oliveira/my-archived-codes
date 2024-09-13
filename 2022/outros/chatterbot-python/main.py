from chatterbot import ChatBot
from chatterbot.trainers import ListTrainer

chatbot = ChatBot('BotName')

trainer = ListTrainer(chatbot)

trainer.train([
	"Olá"
	"Oi como vai você?",
	"Estou bem e você?"
	"Aceita um pedaço de pizza?"
])

while True:
	request = input('Humano: ')
	response = chatbot.get_response(request)
	print('Bot: ', response)
