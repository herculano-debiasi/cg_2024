# -*- coding: utf-8 -*-
import tkinter

app = tkinter.Tk()
app.title('Desenhando 2D')
app.geometry('500x500')

canvas = tkinter.Canvas(app,
                        bg="blue",
                        height=250,
                        width=300)
canvas.pack(pady=100)

coords = 10, 50, 240, 210
linha = canvas.create_line(coords,
                           width=5,
                           fill="red")

app.mainloop()
