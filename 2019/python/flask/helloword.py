from flask import Flask

app = Flask(__name__)

@app.route("/")
def index():
    return "Hello World!"

if __name__ == "__main__": #verifica se a funcao e a principal
    app.run()
