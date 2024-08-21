# -*- coding: utf-8 -*-
import dearpygui.dearpygui as dpg

dpg.create_context()
dpg.create_viewport(title='Olá Mundo!',
                    width=500,
                    height=300)

with dpg.window(label='Janela de Exemplo'):
    dpg.add_text('Olá Mundo!')

    dpg.add_input_text(label='Nome',
                       default_value='Fulano')

    dpg.add_slider_float(label='Idade',
                         default_value=0,
                         max_value=150)

    dpg.add_button(label='Adicionar')

dpg.setup_dearpygui()
dpg.show_viewport()
dpg.start_dearpygui()
dpg.destroy_context()
