package first;

public class FriendNames {

	public static void main(String[] params) {
		if (params.length == 2) { //��� ������� args (params) ��� ��� ��������
			System.out.println("������� �� ������ �������� �� " + params[0] + " � " + params[1]);
		} else {
			System.out.println("������ �� �������� ������� �� ����� ����� ���� �������� ���� ��������� �� ������� ����� main!");
		}

	}

}