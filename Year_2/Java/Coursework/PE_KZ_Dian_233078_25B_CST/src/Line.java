import java.awt.*;

public class Line implements DrawableShape {
    private int startX, startY, endX, endY;
    private Color color;

    public Line(int startX, int startY, int endX, int endY, Color color) {
        this.startX = startX;
        this.startY = startY;
        this.endX = endX;
        this.endY = endY;
        this.color = color;
    }

    public void drawShape(Graphics g) {
        g.setColor(color);
        g.drawLine(startX, startY, endX, endY);
    }

    public String toString() {
        return "Линия => startX: " + startX + ", startY: " + startY + ", endX: " + endX + ", endY: " + endY;
    }
}