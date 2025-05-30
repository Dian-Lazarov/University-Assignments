package first;

public class FriendNames {

	public static void main(String[] params) {
		if (params.length == 2) { //ако масивът args (params) има два елемента
			System.out.println("Имената на вашите приятели са " + params[0] + " и " + params[1]);
		} else {
			System.out.println("Трябва да зададете имената на точно двама Ваши приятели като параметри на главния метод main!");
		}

	}

}