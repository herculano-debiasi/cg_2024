package desenho2d;

import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.DefaultListModel;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.SwingConstants;

public class Desenho2D {
	private enum Acoes {
		DESENHAR, LIMPAR
	}
	
	private Acoes acao = Acoes.LIMPAR;
	
	private JFrame frmDesenhodAvancado;
	private JTextField edtIdade;
	private JTextField edtNome;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Desenho2D window = new Desenho2D();
					window.frmDesenhodAvancado.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Desenho2D() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmDesenhodAvancado = new JFrame();
		frmDesenhodAvancado.setTitle("Desenho2D - Avançado");
		frmDesenhodAvancado.setBounds(100, 100, 678, 379);
		frmDesenhodAvancado.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmDesenhodAvancado.getContentPane().setLayout(null);
		
		JPanel pnlDesenho = new JPanel() {
			protected void paintComponent(Graphics g) {
	            super.paintComponent(g);
	            this.setBackground(Color.WHITE);
	            g.setColor(Color.BLACK);
	            Graphics2D g2d = (Graphics2D) g.create();
	            
	            if(acao == Acoes.DESENHAR) {
	            	g2d.drawLine(10, 10, 100, 100);
	            } else if(acao == Acoes.LIMPAR){
	            	g2d.clearRect(0, 0, 100, 100);
	            }
	            
	            g2d.dispose();
	        }
		};
		
		pnlDesenho.setBounds(10, 11, 316, 285);
		frmDesenhodAvancado.getContentPane().add(pnlDesenho);
		
		JButton btnDesenhar = new JButton("Desenhar");
		btnDesenhar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				acao = Acoes.DESENHAR;
				frmDesenhodAvancado.repaint();
			}
		});
		btnDesenhar.setBounds(10, 307, 89, 23);
		frmDesenhodAvancado.getContentPane().add(btnDesenhar);
		
		JButton btnLimpar = new JButton("Limpar");
		btnLimpar.setBounds(237, 307, 89, 23);
		frmDesenhodAvancado.getContentPane().add(btnLimpar);
		
		edtIdade = new JTextField();
		edtIdade.setBounds(399, 43, 89, 20);
		frmDesenhodAvancado.getContentPane().add(edtIdade);
		edtIdade.setColumns(10);
		
		JCheckBox ckbxPoligono = new JCheckBox("Polígono");
		ckbxPoligono.setBounds(399, 70, 97, 23);
		frmDesenhodAvancado.getContentPane().add(ckbxPoligono);
		
		JLabel lblNewLabel = new JLabel("Idade:");
		lblNewLabel.setHorizontalAlignment(SwingConstants.RIGHT);
		lblNewLabel.setBounds(332, 46, 61, 14);
		frmDesenhodAvancado.getContentPane().add(lblNewLabel);
		
		JList<Pessoa> lstObjetos = new JList();
//		lstObjetos.setFont(new java.awt.Font("Tahoma", 0, 24));
		lstObjetos.setBounds(336, 100, 316, 111);
		frmDesenhodAvancado.getContentPane().add(lstObjetos);
		
		DefaultListModel listModel = new DefaultListModel();
		lstObjetos.setModel(listModel);
		
		JButton btnTestar = new JButton("Adicionar");
		btnTestar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {			
				Pessoa p = new Pessoa(edtNome.getText(), 
									  Integer.valueOf(edtIdade.getText()));
				listModel.addElement(p);

				edtNome.setText("");
				edtIdade.setText("");
			}
		});
		btnTestar.setBounds(437, 222, 124, 23);
		frmDesenhodAvancado.getContentPane().add(btnTestar);
		
		btnLimpar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				acao = Acoes.LIMPAR;
				
				listModel.clear();
				frmDesenhodAvancado.repaint();
			}
		});
		
		JButton btnMostrarInfos = new JButton("Mostrar Infos.");
		btnMostrarInfos.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int posicao = lstObjetos.getSelectedIndex();
				if (posicao != -1) {
					Pessoa p = (Pessoa) lstObjetos.getSelectedValue();
					JOptionPane.showMessageDialog(null, 
												  p.getNome() + " - " + 
												  p.getIdade() + "\n" + 
												  "Caixa polígono está " + (ckbxPoligono.isSelected()?"marcada":"desmarcada") + "\n" + 
												  "Número de itens na caixa: " + lstObjetos.getModel().getSize() + "\n" + 
												  "Índice selecionado: " + posicao);
				} else {
					JOptionPane.showMessageDialog(null, "Nenhum item selecionado!");
				}
			}
		});
		btnMostrarInfos.setBounds(437, 256, 124, 23);
		frmDesenhodAvancado.getContentPane().add(btnMostrarInfos);
		
		JLabel lblNome = new JLabel("Nome:");
		lblNome.setHorizontalAlignment(SwingConstants.RIGHT);
		lblNome.setBounds(336, 24, 57, 14);
		frmDesenhodAvancado.getContentPane().add(lblNome);
		
		edtNome = new JTextField();
		edtNome.setColumns(10);
		edtNome.setBounds(399, 21, 253, 20);
		frmDesenhodAvancado.getContentPane().add(edtNome);
	}
}
