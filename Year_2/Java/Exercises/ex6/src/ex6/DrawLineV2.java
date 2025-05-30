package ex6;

import java.awt.*;
import java.awt.event.*;

public class DrawLineV2 extends Frame {
	int startX = 0, startY = 0; // Starting point coordinates
	int endX = 0, endY = 0; // Ending point coordinates
	boolean drawing = false; // Flag to check if drawing is in progress

	public DrawLineV2() {
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
				drawing = true;
			}

			@Override
			public void mouseReleased(MouseEvent m) {
				// Stop drawing when the mouse is released
				drawing = false;
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

		// Register MouseMotionListener to handle mouse dragging events
		addMouseMotionListener(new MouseMotionListener() {
			@Override
			public void mouseDragged(MouseEvent m) {
				// Set the current mouse position as the endpoint while dragging
				if (drawing) {
					endX = m.getX();
					endY = m.getY();
					repaint();
				}
			}

			@Override
			public void mouseMoved(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
		});
	}

	@Override
	public void paint(Graphics g) {
		// Draw the line if in drawing mode
		if (drawing) {
			g.clearRect(0, 0, getWidth(), getHeight()); // Clear previous drawings
			g.drawLine(startX, startY, endX, endY); // Draw the line segment
		}
	}

	public static void main(String[] args) {
		new DrawLineV2();
	}
}
