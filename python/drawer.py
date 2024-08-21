# -*- coding: utf-8 -*-
from enum import Enum

from PyQt5.QtWidgets import QWidget
from PyQt5.QtGui import QPainter, QPen
from PyQt5.QtCore import Qt

Acoes = Enum('Acoes', 'DESENHAR LIMPAR')


class Drawer(QWidget):
    def __init__(self, parent=None):
        super().__init__(parent)
        self.acao = Acoes.LIMPAR
        self.update()

    def mousePressEvent(self, event):
        if event.button() == Qt.LeftButton:
            self.acao = Acoes.DESENHAR
        else:
            self.acao = Acoes.LIMPAR

        self.update()

    def desenhar(self):
        self.acao = Acoes.DESENHAR
        print('\ndesenhar - ' + str(self.acao))

    def limpar(self):
        self.acao = Acoes.LIMPAR
        print('\nlimpar - ' + str(self.acao))

    def paintEvent(self, event):
        rect = event.rect()
        painter = QPainter()

        painter.begin(self)
        painter.setRenderHint(QPainter.Antialiasing)

        painter.setBackground(Qt.white)
        painter.setBrush(Qt.black)
        painter.setPen(QPen(Qt.black, 2, Qt.SolidLine))
        painter.eraseRect(rect)

        print('paintEvent - ' + str(self.acao))
        if self.acao is Acoes.DESENHAR:
            painter.drawLine(0, 0, 200, 200)

        painter.end()
