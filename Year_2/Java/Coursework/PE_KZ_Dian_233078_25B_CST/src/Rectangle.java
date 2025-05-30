import java.awt.*;

public class Rectangle implements DrawableShape {
    private int x, y, width, height;
    private Color color;

    public Rectangle(int x, int y, int width, int height, Color color) {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
        this.color = color;
    }

    public void drawShape(Graphics g) {
        g.setColor(color);
        g.drawRect(x, y, width, height);
    }
    
    public String toString() {
        return "Четириъгълник => x: " + x + ", y: " + y + ", width: " + width + ", height: " + height;
    }
}