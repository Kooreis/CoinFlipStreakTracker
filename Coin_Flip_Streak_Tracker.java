```java
import java.util.Random;

public class CoinFlipStreakTracker {
    public static void main(String[] args) {
        Random rand = new Random();
        int streak = 0;
        String lastFlip = "";
        for (int i = 0; i < 100; i++) {
            int flip = rand.nextInt(2);
            String currentFlip = flip == 0 ? "Heads" : "Tails";
            System.out.println(currentFlip);
            if (currentFlip.equals(lastFlip)) {
                streak++;
            } else {
                streak = 1;
            }
            System.out.println("Streak: " + streak);
            lastFlip = currentFlip;
        }
    }
}
```