package ex9;

import java.awt.*;
import java.awt.event.*;
import java.util.*;

public class Scroller extends Frame {
    /*
     * fullstring -> the entire string to scroll; currstring -> the current string,
     * obtained as a substring of the entire index -> index of the current position
     * in the string, from which the current string begins
     */
    private String fullstring, currstring;
    private int index = 0;

    class MyTimerTask extends TimerTask {
        public void run() {
            /*
             * obtaining the current string as a substring of the full one, with the
             * beginning of the substring being the current value of index in the scrolling
             * string - for the required method of the String class, refer to the
             * documentation
             */
            currstring = fullstring.substring(index);

            // Increment the current position in the string by 1
            index++;

            /*
             * if the received current position exceeds or is equal to the length of the
             * scrolling string, the current position in the string gets the value 0
             */
            if (index >= fullstring.length()) {
                index = 0;
            }

            // Repaint the window to update the displayed text
            repaint();
        } // end of the run method body
    } // end of the MyTimerTask class definition

    public Scroller() {
        setSize(400, 100);
        setLocationRelativeTo(null);
        addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                System.exit(0);
            }
        });

        // Initialize the full string to scroll
        fullstring = "This is a scrolling text";

        // Set up a timer to execute the scrolling logic at fixed intervals
        Timer timer = new Timer();
        TimerTask task = new MyTimerTask(); // My
        timer.scheduleAtFixedRate(task, 0, 200);
        // timer.scheduleAtFixedRate(new MyTimerTask(), 0, 100);

        setVisible(true);
    }

    public static void main(String[] a) {
        // Create an object of the Scroller class
        new Scroller();
    }

    public void paint(Graphics g) {
        if (currstring == null)
            return;
        g.drawString(currstring, 10, 50);
    }
} // end of the definition of the Scroller class