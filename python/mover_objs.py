# -*- coding: utf-8 -*-
import tkinter


def mover(e):
    coordenadas.config(text=f'Coordenadas: x= {e.x} y={e.y}')

    global img
    img = tkinter.PhotoImage(file='eu.png')
    img = img.subsample(2, 2)
    canvas.create_image(e.x, e.y, image=img)


def sairBotao():
    sair('')


def sair(event):
    resposta = tkinter.messagebox.askyesno('Sair', 'Sair?')
    if resposta == 1:
        app.destroy()


app = tkinter.Tk()
app.title('Desenhando 2D')
app.geometry('800x600')

canvas = tkinter.Canvas(app, bg="white", width=700, height=500)

coordenadas = tkinter.Label(app, text=" ")
botao = tkinter.Button(app, text='Sair', width=10, command=sairBotao)

coordenadas.grid(row=0, column=1, pady=4)
canvas.grid(row=1, column=1, padx=50)
botao.grid(row=3, column=1, pady=17)

app.bind('<Left>', lambda event: canvas.move(circulo, -10, 0))
app.bind('<Right>', lambda event: canvas.move(circulo, 10, 0))
app.bind('<Up>', lambda event: canvas.move(circulo, 0, -10))
app.bind('<Down>', lambda event: canvas.move(circulo, 0, 10))
app.bind('<Escape>', sair)

app.bind('<B1-Motion>', mover)

circulo = canvas.create_oval(350, 250, 360, 260)

img = tkinter.PhotoImage(file='eu.png')
img = img.subsample(2, 2)
imagem = canvas.create_image(10, 10, anchor=tkinter.NW, image=img)

app.mainloop()
