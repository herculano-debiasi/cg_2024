# -*- coding: utf-8 -*-
import PySimpleGUI as sg


texto = 'Minha simples aplicação!'

layout = [
    [sg.Button(texto)]
]

window = sg.Window('Olá Mundo!', layout)

while True:
    event, values = window.read()
    print(event, values)
    if event == sg.WIN_CLOSED or event == texto:
        break

window.close()
