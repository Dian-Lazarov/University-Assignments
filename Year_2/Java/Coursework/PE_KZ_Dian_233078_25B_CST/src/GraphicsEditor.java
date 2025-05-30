import java.awt.*;
import java.awt.event.*;
import java.awt.List;
import java.util.ArrayList;
import javax.swing.JColorChooser;

public class GraphicsEditor extends Frame {
	private List shapeList = new List();
	private ArrayList<DrawableShape> shapes = new ArrayList<DrawableShape>();
	private int startX, startY, endX, endY;
	private int x, y, width, height;
	private Color currentColor;
	private Color chosenColor;
	private String selectedShape;

	public GraphicsEditor() {
		setTitle("Векторен графичен редактор");
		setSize(900, 800);
		setLocationRelativeTo(null);

		// създаване на списък от примитиви
		String Line = new String("Линия");
		String Rectangle = new String("Четириъгълник");
		String Oval = new String("Овал");
		shapeList.add(Line);
		shapeList.add(Rectangle);
		shapeList.add(Oval);
		shapeList.select(0);

		// слушател за затваряне на прозореца
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});

		// бутон за извеждане на съдържанието на колекцията в конзолата
		Button displayShapes = new Button("Отпечатване на съдържанието");
		displayShapes.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.out.println("Изчертани примитиви:");
				for (int i = 0; i < shapes.size(); i++) {
					DrawableShape shape = shapes.get(i);
					System.out.println(shape.toString());
				}
			}
		});

		// бутон за избор на цвят
		Button chooseColor = new Button("Избор на цвят");
		chooseColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				chosenColor = JColorChooser.showDialog(null, "Цветове", currentColor);
				currentColor = chosenColor;
			}
		});

		// добавяне на компонентите към панел, разположен в горната част на прозореца
		Panel top = new Panel();
		Label selectList = new Label("Избор на примитив:");
		top.add(selectList);
		top.add(shapeList);
		top.add(displayShapes);
		top.add(chooseColor);
		add(top, BorderLayout.NORTH);

		// слушател на мишката, необходим за изчертаване на примитивите
		addMouseListener(new MouseAdapter() {
			public void mousePressed(MouseEvent e) {
				startX = e.getX();
				startY = e.getY();
				selectedShape = shapeList.getSelectedItem();
			}

			public void mouseReleased(MouseEvent e) {
				endX = e.getX();
				endY = e.getY();

				if (selectedShape.equals(Line)) {
					DrawableShape line = new Line(startX, startY, endX, endY, currentColor);
					shapes.add(line);

				} else if (selectedShape.equals(Rectangle)) {
					x = FindMin(startX, endX);
					y = FindMin(startY, endY);
					width = FindMod(endX - startX);
					height = FindMod(endY - startY);
					DrawableShape rectangle = new Rectangle(x, y, width, height, currentColor);
					shapes.add(rectangle);

				} else if (selectedShape.equals(Oval)) {
					x = FindMin(startX, endX);
					y = FindMin(startY, endY);
					width = FindMod(endX - startX);
					height = FindMod(endY - startY);
					DrawableShape oval = new Oval(x, y, width, height, currentColor);
					shapes.add(oval);
				}
				repaint();
			}
		});
		setVisible(true);
	}

	// обхождане на колекцията и извикване на метода drawShape в paint
	public void paint(Graphics g) {
		for (int i = 0; i < shapes.size(); i++) {
			DrawableShape shape = shapes.get(i);
			shape.drawShape(g);
		}
	}

	// метод за намиране на минимална стойност
	int FindMin(int a, int b) {
		if (a < b) {
			return a;
		} else {
			return b;
		}
	}

	// метод за намиране на модул
	int FindMod(int a) {
		if (a < 0) {
			return -a;
		} else {
			return a;
		}
	}

	public static void main(String[] args) {
		new GraphicsEditor();
	}
}