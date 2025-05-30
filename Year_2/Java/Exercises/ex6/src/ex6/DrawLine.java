package ex6;

import java.awt.*;
import java.awt.event.*;

public class DrawLine extends Frame {
	int startX = 0, startY = 0; // Starting point coordinates
	int endX = 0, endY = 0; // Ending point coordinates
	// boolean drawing = false; // Flag to check if drawing is in progress

	public DrawLine() {
		// Add a WindowListener to close the program when the window is closed
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});

		// Set up the window properties
		setTitle("Line Segment Drawer");
		setSize(500, 500);
		setLocationRelativeTo(null);
		setVisible(true);

		// Register MouseListener to handle mouse press and release events
		addMouseListener(new MouseListener() {
			@Override
			public void mousePressed(MouseEvent m) {
				// Set the starting point when the mouse is pressed
				startX = m.getX();
				startY = m.getY();
				// drawing = true;
			}

			@Override
			public void mouseReleased(MouseEvent m) {
				// Set the ending point when the mouse is released
				endX = m.getX();
				endY = m.getY();
				// drawing = false;

				// Repaint to display the line
				repaint();
			}

			@Override
			public void mouseClicked(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void mouseExited(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
		});
	}

	@Override
	public void paint(Graphics g) {
		// Draw the line only if a complete segment is defined
		g.drawLine(startX, startY, endX, endY); // if(!drawing)
	}

	public static void main(String[] args) {
		new DrawLine();
	}
}
