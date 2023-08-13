```python
import random

def coin_flip():
    return 'Heads' if random.randint(0, 1) == 0 else 'Tails'

def streak_tracker():
    streak_count = 0
    flip_result = coin_flip()
    print(flip_result)

    while True:
        next_flip = coin_flip()
        print(next_flip)

        if next_flip == flip_result:
            streak_count += 1
        else:
            streak_count = 0
            flip_result = next_flip

        if streak_count == 6:
            print('Streak of 6!')
            break

streak_tracker()
```