import java.awt.*;

public class Oval implements DrawableShape {
    private int x, y, width, height;
    private Color color;

    public Oval(int x, int y, int width, int height, Color color) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.color = color;
    }

    public void drawShape(Graphics g) {
        g.setColor(color);
        g.drawOval(x, y, width, height);
    }

    public String toString() {
        return "Овал => x: " + x + ", y: " + y + ", width: " + width + ", height: " + height;
    }
}