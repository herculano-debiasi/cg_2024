# -*- coding: utf-8 -*-
from PyQt5 import QtWidgets
from PyQt5.QtWidgets import QApplication, QMainWindow
import sys


def on_clicked():
    print('Clicked!')


def window():
    app = QApplication(sys.argv)

    win = QMainWindow()
    win.setGeometry(200, 200, 300, 300)
    win.setWindowTitle('Janela Principal')

    # Cria um 'rótulo' (label)
    label = QtWidgets.QLabel(win)
    label.setText('Hello World!')
    label.move(50, 50)

    # Cria um botão
    btn = QtWidgets.QPushButton(win)
    btn.setText('Click on me')
    btn.clicked.connect(on_clicked)

    # Mostra a janela
    win.show()

    # Saída limpa do aplicativo
    sys.exit(app.exec_())


window()
