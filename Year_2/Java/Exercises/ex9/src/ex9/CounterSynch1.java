package ex9;

import java.awt.*;
import java.awt.event.*;

public class CounterSynch1 extends Frame {

	class DemoThread extends Thread {
		private boolean abortrequested;

		DemoThread() {
			super();
			abortrequested = false;
		}

		public void abort() {
			abortrequested = true;
		}

		@Override
		public void run() {

			System.out.println("Entering run, thread:" + currentThread());
			for (int c = 0; c < 100; c++) {
				incrementCounter(); // Synchronizing the increment operation
				if (abortrequested)
					break;
				try {
					sleep(50);
				} catch (InterruptedException e) {
					e.printStackTrace();
				}
			}
			System.out.println("Leaving run, thread:" + currentThread());
			long taken = System.currentTimeMillis() - startTime;
			sStatus.setText("Took " + taken + " milliseconds");
		}
	}

	Label cntVal;
	Label sStatus;
	int numThreads = 3;
	long startTime;
	DemoThread threads[];

	public CounterSynch1() {
		threads = new DemoThread[numThreads];
		startTime = 0;

		// UI - не е интересно за това упражнение
		setSize(320, 200);
		setLocationRelativeTo(null);
		setLayout(null);
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				for (int i = 0; i < threads.length; i++) {
					if (threads[i] != null)
						try {
							threads[i].join();
						} catch (InterruptedException x) {
						}
				}
				System.exit(0);
			}
		});
		Button startButton = new Button("start");
		startButton.setBounds(10, 40, 40, 24);
		startButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				startAll();
			}
		});
		add(startButton);

		cntVal = new Label("");
		cntVal.setBounds(80, 40, 100, 24);
		cntVal.setText("0");
		add(cntVal);

		sStatus = new Label("");
		sStatus.setBounds(10, 120, 200, 24);
		add(sStatus);

		setVisible(true);
	}
	
	// Synchronized method to safely increment the counter
	private synchronized void incrementCounter() {
        String s = cntVal.getText();
        int cnt = Integer.parseInt(s);
        cnt++;
        cntVal.setText(Integer.toString(cnt));
    }

	void startAll() {
		startTime = System.currentTimeMillis();
		for (int i = 0; i < threads.length; i++) {
			if (threads[i] == null || !threads[i].isAlive()) {
				threads[i] = new DemoThread();
				threads[i].start();
				System.out.println("Started thread " + i + ":" + threads[i]);
			} else
				System.out.println("Thread " + i + " is alive already!");
		}
	}

	public static void main(String[] args) {
		new CounterSynch1();
	}
}