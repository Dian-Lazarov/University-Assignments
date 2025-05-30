package ex5;

import java.awt.*;
import java.awt.event.*;

public class Circle extends Frame {

    public Circle() {
        addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                System.exit(0);
            }
        });

        setTitle("Centered Circle");
        setSize(500, 500);
        setLocationRelativeTo(null);
        setBackground(Color.green);
        setVisible(true);
    }

    public void paint(Graphics g) {
    	Rectangle rec = new Rectangle(getBounds());
    	rec.width=getWidth();
    	rec.height=getHeight();

        int diameter = 200;  // The diameter of the circle
        int radius = diameter / 2;

        // Calculate the top-left corner of the circle to center it
        int x = (rec.width / 2) - radius;
        int y = (rec.height / 2) - radius;

        // Set the circle color and draw the circle
        g.setColor(Color.white);
        g.fillOval(x, y, diameter, diameter);
    }

    public static void main(String[] args) {
        new Circle();
    }
}