# -*- coding: utf-8 -*-
import wx


class MainWindow(wx.Frame):
    def __init__(self, parent, title):
        wx.Frame.__init__(self, parent, title=title, size=(300, -1))

        self.button = wx.Button(self, label='Minha aplicação simples!')
        self.Bind(
            wx.EVT_BUTTON, self.handle_button_click, self.button
        )

        self.sizer = wx.BoxSizer(wx.VERTICAL)
        self.sizer.Add(self.button)

        self.SetSizer(self.sizer)
        self.SetAutoLayout(True)
        self.Show()

    def handle_button_click(self, event):
        self.Close()


app = wx.App(False)
w = MainWindow(None, 'Olá Mundo!')
app.MainLoop()
