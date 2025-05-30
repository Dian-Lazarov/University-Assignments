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
		setTitle("�������� �������� ��������");
		setSize(900, 800);
		setLocationRelativeTo(null);

		// ��������� �� ������ �� ���������
		String Line = new String("�����");
		String Rectangle = new String("�������������");
		String Oval = new String("����");
		shapeList.add(Line);
		shapeList.add(Rectangle);
		shapeList.add(Oval);
		shapeList.select(0);

		// �������� �� ��������� �� ���������
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});

		// ����� �� ��������� �� ������������ �� ���������� � ���������
		Button displayShapes = new Button("����������� �� ������������");
		displayShapes.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.out.println("��������� ���������:");
				for (int i = 0; i < shapes.size(); i++) {
					DrawableShape shape = shapes.get(i);
					System.out.println(shape.toString());
				}
			}
		});

		// ����� �� ����� �� ����
		Button chooseColor = new Button("����� �� ����");
		chooseColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				chosenColor = JColorChooser.showDialog(null, "�������", currentColor);
				currentColor = chosenColor;
			}
		});

		// �������� �� ������������ ��� �����, ���������� � ������� ���� �� ���������
		Panel top = new Panel();
		Label selectList = new Label("����� �� ��������:");
		top.add(selectList);
		top.add(shapeList);
		top.add(displayShapes);
		top.add(chooseColor);
		add(top, BorderLayout.NORTH);

		// �������� �� �������, ��������� �� ����������� �� �����������
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

	// ��������� �� ���������� � ��������� �� ������ drawShape � paint
	public void paint(Graphics g) {
		for (int i = 0; i < shapes.size(); i++) {
			DrawableShape shape = shapes.get(i);
			shape.drawShape(g);
		}
	}

	// ����� �� �������� �� ��������� ��������
	int FindMin(int a, int b) {
		if (a < b) {
			return a;
		} else {
			return b;
		}
	}

	// ����� �� �������� �� �����
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