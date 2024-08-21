# -*- coding: utf-8 -*-
from PyQt5 import QtWidgets
from PyQt5.QtWidgets import QApplication, QMainWindow
import sys


class MyWindow(QMainWindow):
    def __init__(self):
        super(MyWindow, self).__init__()

        self.setGeometry(200, 200, 300, 300)
        self.setWindowTitle('Janela Principal')

        self.initUI()

    def initUI(self):
        # Cria um 'rótulo' (label)
        self.label = QtWidgets.QLabel(self)
        self.label.setText('Hello World!')
        self.label.move(50, 50)

        # Cria um botão
        self.btn = QtWidgets.QPushButton(self)
        self.btn.setText('Click on me')
        self.btn.clicked.connect(self.clicked)

    def clicked(self):
        self.label.setText('you pressed the button')
        print('Clicked!')
        self.update()

    def update(self):
        self.label.adjustSize()


def main():
    app = QApplication(sys.argv)
    win = MyWindow()

    # Mostra a janela
    win.show()

    # Saída limpa do aplicativo
    sys.exit(app.exec_())


if __name__ == '__main__':
    main()
