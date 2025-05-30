package ex9;

import java.awt.*;
import java.awt.event.*;

public class Grph extends Frame {
	private int fillColour;
	private Button btnStart;
	private Button btnExit;
	private final int DURATION = 10;

	public Grph() {
		setSize(320, 240);
		setResizable(false);
		setLocationRelativeTo(null);
		setLayout(null);

		// Inner thread class
		/*
		 * class GrphThread extends Thread {
		 * 
		 * @Override public void run() { doGraphics(); // Call the graphics method in
		 * the thread's run method } }
		 */

		class GrphRunnable implements Runnable {
			@Override
			public void run() {
				doGraphics();
			}
		}

		btnStart = new Button("Start");
		btnStart.setBounds(80, 200, 60, 20);
		add(btnStart);
		btnStart.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				// Start a new thread that executes the doGraphics() method
				// GrphThread gth = new GrphThread();
				// new GrphThread().start();
				// gth.start();

				GrphRunnable gth = new GrphRunnable();
				Thread th = new Thread(gth);
				th.start();
				// Thread gth = new Thread(new GrphRunnable()); gth.start();
			}
		});

		btnExit = new Button("Close program");
		btnExit.setBounds(150, 200, 100, 20);
		add(btnExit);
		btnExit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
			}
		});

		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent w) {
				System.exit(0);
			}
		});

		setVisible(true);
	}

	public void paint(Graphics g) {
		g.setColor(new Color(fillColour));
		g.fillRect(110, 40, 100, 100);
	}

	// The method that contains the graphics loop
	public void doGraphics() {
		long start = System.currentTimeMillis();
		while (true) {
			btnStart.setEnabled(false);
			fillColour = (int) Math.round(Math.random() * 0x00ffffff); // Random color
			repaint();
			try {
				Thread.sleep(80); // Pause for 80 ms
			} catch (Exception e) {
				e.printStackTrace();
			}
			btnStart.setEnabled(true);
			if (System.currentTimeMillis() - start > DURATION * 1000) { // Stop after the duration
				break;
			}
		}
	}

	public static void main(String[] args) {
		new Grph();
	}
}