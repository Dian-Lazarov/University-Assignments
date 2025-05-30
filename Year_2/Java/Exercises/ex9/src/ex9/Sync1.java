package ex9;

import java.awt.*;
import java.awt.event.*;

class Foo extends Frame {

	private int cnt1, cnt2, synccnt, unsynccnt;
	Label l1, l2, lsync, lunsync;

	class Thread1 extends Thread { // �����1 - ������� � ����� p1()
		private boolean stopped = false; // ���� �� ��������� �������

		@Override
		public void run() {
			while (!stopped) {
				p1();
			}
		}

		public void safestop() {
			stopped = true;
		}
	}

	class Thread2 extends Thread { // �����2 - ������� � ����� p2()
		private boolean stopped = false; // ���� �� ��������� �������

		@Override
		public void run() {
			while (!stopped) {
				p2();
			}
		}

		public void safestop() {
			stopped = true;
		}
	}

	public Foo() { // ����������� - ���� ��������� �� ���� ����������
		cnt1 = cnt2 = synccnt = unsynccnt = 0;
		setSize(420, 200);
		setLocationRelativeTo(null);
		setLayout(new GridLayout(2, 2));
		Panel upper = new Panel();
		upper.setLayout(new GridLayout(0, 2));
		add(upper);
		Panel lower = new Panel();
		lower.setLayout(new GridLayout(0, 4));
		add(lower);

		upper.add(new Label("Thread1", Label.CENTER));
		upper.add(new Label("Thread2", Label.CENTER));
		l1 = new Label("");
		lower.add(l1);
		l2 = new Label("");
		lower.add(l2);
		lsync = new Label("");
		lower.add(lsync);
		lunsync = new Label("");
		lower.add(lunsync);
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});
		setVisible(true);
	}

	public synchronized void p1() {
		cnt1 = cnt1 + 1;
		System.out.print("<1>");
		l1.setText("" + cnt1);
		cnt2 = cnt2 + 1;
		System.out.print("<2>");
		l2.setText("" + cnt2);
	}

	public synchronized void p2() {
		System.out.print("\ncnt1=" + cnt1 + ", cnt2=" + cnt2);
		String status = "";
		if (cnt1 != cnt2) {
			System.out.println("  <-- UNSYNC");
			unsynccnt++;
			lunsync.setText("UNSYNC (" + unsynccnt + ")");
		} else {
			System.out.println("  <--   SYNC");
			synccnt++;
			lsync.setText("  SYNC (" + synccnt + ")");
		}
	}

	public void go() { // �������� ����� ����� �� 5 �������
		Thread1 th1 = new Thread1();
		Thread2 th2 = new Thread2();

		th1.setPriority(Thread.NORM_PRIORITY); // +2
		// th1.setPriority(Thread.MIN_PRIORITY);
		// th1.setPriority(Thread.MAX_PRIORITY);
		th2.setPriority(Thread.NORM_PRIORITY);
		// th2.setPriority(Thread.MIN_PRIORITY);
		// th2.setPriority(Thread.MAX_PRIORITY);

		long initt = System.currentTimeMillis();
		th2.start();
		th1.start();
		while (System.currentTimeMillis() - initt < 5000);
		th2.safestop();
		th1.safestop();

	}
}

public class Sync1 {
	public static void main(String argv[]) {
		Foo f = new Foo();
		f.go();
	}
}