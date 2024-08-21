# -*- coding: utf-8 -*-
from drawer import Drawer
from PyQt5 import QtWidgets, uic, QtCore
from PyQt5.QtWidgets import QMessageBox
from PyQt5.QtCore import Qt
import sys


class Pessoa():
    def __init__(self, nome='', idade=0):
        self.nome = nome
        self.idade = idade

    def __str__(self):
        return f'Pessoa [nome={self.nome}, idade={self.idade}]'


class PessoaModel(QtCore.QAbstractListModel):
    def __init__(self, *args, pessoas=None, **kwargs):
        super(PessoaModel, self).__init__(*args, **kwargs)
        self.pessoas = pessoas or []

    def data(self, index, role):
        if role == Qt.ItemDataRole.DisplayRole:
            # See below for the data structure.
            status, pessoa = self.pessoas[index.row()]
            # Return the todo text only.
            return pessoa.nome + ' - ' + pessoa.idade

    def rowCount(self, index):
        return len(self.pessoas)


class Ui(QtWidgets.QMainWindow):
    def __init__(self):
        super(Ui, self).__init__()
        uic.loadUi('cg_avancado.ui', self)
        self.drawer = Drawer()
        self.initUI()
        self.show()

    def initUI(self):
        self.pbAdicionar.clicked.connect(self.adicionar)
        self.pbMostrarInfos.pressed.connect(self.mostrar_infos)
        self.pbRemover.pressed.connect(self.remover)

        self.pbDesenhar.clicked.connect(self.desenhar)
        self.pbLimpar.clicked.connect(self.limpar)

        self.model = PessoaModel()
        self.lwObjetos.setModel(self.model)

    def desenhar(self):
        self.drawer.desenhar()
        self.update()

    def limpar(self):
        self.drawer.limpar()
        self.update()

    def adicionar(self):
        p = Pessoa(self.leNome.text(), self.leIdade.text())
        self.model.pessoas.append((False, p))
        self.model.layoutChanged.emit()

        self.leNome.setText('')
        self.leIdade.setText('')

    def remover(self):
        msg = QMessageBox()
        msg.setWindowTitle('CG')

        indexes = self.lwObjetos.selectedIndexes()
        if indexes:
            index = indexes[0]
            del self.model.pessoas[index.row()]

            self.model.layoutChanged.emit()
            self.lwObjetos.clearSelection()
        else:
            msg.setText('Nenhum item selecionado!')

        msg.exec()

    def mostrar_infos(self):
        msg = QMessageBox()
        msg.setWindowTitle('CG')

        indexes = self.lwObjetos.selectedIndexes()
        if indexes:
            index = indexes[0].row()
            msg.setText(f'{self.model.pessoas[index][1]}\n' + 
                        f'Caixa polígono está {"marcada" if self.cbPoligono.isChecked() else "desmarcada"}\n' +
                        f'Número de itens na caixa: {len(self.model.pessoas)}\n' +
                        f'Índice selecionado: {index}')
        else:
            msg.setText('Nenhum item selecionado!')

        msg.exec()


app = QtWidgets.QApplication(sys.argv)
window = Ui()
app.exec_()
