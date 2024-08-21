# -*- coding: utf-8 -*-
from kivy.app import App
from kivy.uix.boxlayout import BoxLayout
from kivy.uix.button import Button
from kivy.core.window import Window

Window.size = (300, 200)


class MainWindow(BoxLayout):
    def __init__(self):
        super().__init__()
        self.button = Button(text='Olá Mundo?')
        self.button.bind(on_press=self.handle_button_clicked)
        self.add_widget(self.button)

    def handle_button_clicked(self, event):
        self.button.text = 'Olá Mundo!'


class MyApp(App):
    def build(self):
        self.title = 'Olá Mundo!'
        return MainWindow()


app = MyApp()
app.run()
