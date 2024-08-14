package desenho2d;

import java.awt.EventQueue;
import java.awt.Graphics2D;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JPanel;

public class Desenho2D {
	private JFrame frmDesenho2dBasico;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Desenho2D window = new Desenho2D();
					window.frmDesenho2dBasico.setVisible(true);
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
		frmDesenho2dBasico = new JFrame();
		frmDesenho2dBasico.setTitle("Desenho2D - Básico");
		frmDesenho2dBasico.setBounds(100, 100, 236, 300);
		frmDesenho2dBasico.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmDesenho2dBasico.getContentPane().setLayout(null);
		
		JPanel pnlDesenho = new JPanel();
		
		pnlDesenho.setBounds(10, 10, 200, 200);
		frmDesenho2dBasico.getContentPane().add(pnlDesenho);
		
		JButton btnDesenhar = new JButton("Desenhar");
		btnDesenhar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Graphics2D g2d = (Graphics2D) pnlDesenho.getGraphics();
				g2d.drawLine(10, 10, 100, 100);
			}
		});
		btnDesenhar.setBounds(10, 221, 89, 23);
		frmDesenho2dBasico.getContentPane().add(btnDesenhar);
		
		JButton btnLimpar = new JButton("Limpar");
		btnLimpar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Graphics2D g2d = (Graphics2D) pnlDesenho.getGraphics();
				g2d.clearRect(0, 0, 100, 100);
			}
		});
		btnLimpar.setBounds(121, 221, 89, 23);
		frmDesenho2dBasico.getContentPane().add(btnLimpar);
	}
}
