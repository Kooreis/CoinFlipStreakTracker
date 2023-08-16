# Python Documentation

# Coin Flip Streak Tracker

This Python script simulates a coin flip and tracks the occurrence of streaks. A streak is defined as the same result (either Heads or Tails) occurring consecutively. The script continues to flip the coin until a streak of 6 is achieved.

## Libraries Used

- `random`: This is a built-in Python library that generates pseudo-random numbers. It is used in this script to simulate the randomness of a coin flip.

## Functions

### `coin_flip()`

This function simulates a coin flip. It uses the `random.randint(0, 1)` function to generate a random integer between 0 and 1. If the result is 0, the function returns 'Heads'. If the result is 1, it returns 'Tails'.

### `streak_tracker()`

This function tracks the occurrence of streaks in the coin flips. It starts by initializing a streak count to 0 and performing an initial coin flip. The result of the flip is printed to the console.

The function then enters an infinite loop, where it continues to flip the coin. The result of each flip is printed to the console. If the result of the current flip is the same as the previous flip, the streak count is incremented by 1. If the result is different, the streak count is reset to 0 and the result of the current flip is stored for comparison with the next flip.

The loop continues until a streak of 6 is achieved, at which point a message is printed to the console and the loop is exited.

## Execution

To run the script, simply call the `streak_tracker()` function. The script will then start flipping the coin and tracking streaks until a streak of 6 is achieved.

---

# C# Documentation

# Coin Flip Streak Counter

This is a simple C# script that simulates the flipping of a coin and counts the number of consecutive times the same result (Heads or Tails) occurs.

## Script Description

The script starts by initializing a `Random` object, a `streak` counter, and a `lastFlip` string. It then enters an infinite loop where it simulates a coin flip by generating a random number (0 or 1) and assigns the result ("Heads" or "Tails") based on the generated number.

If it's the first flip, it sets the `lastFlip` to the current result and starts the `streak` counter. If the current flip result is the same as the `lastFlip`, it increments the `streak` counter. If the current flip result is different, it prints the `lastFlip` result and the `streak` count, resets the `lastFlip` to the current result, and resets the `streak` counter to 1.

The result of each flip is printed to the console, and the script pauses for 1 second before the next flip.

## Imported Libraries

- `System`: This is a fundamental namespace in .NET that provides classes for string manipulation, data type conversion, and mathematical functions, among other things. In this script, it is used to access the `Random` class for generating random numbers, the `Console` class for writing output to the console, and the `Thread` class for pausing the script.

## Usage

To run the script, you need a .NET environment. You can compile and run the script using the `csc` command (C# Compiler) followed by the `mono` command (if you're on Linux or macOS), or directly with `dotnet run` command (if you're on .NET Core).

```bash
csc Program.cs
mono Program.exe
```

or

```bash
dotnet run Program.cs
```

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

---

# Java Documentation

# CoinFlipStreakTracker

This Java script, `CoinFlipStreakTracker`, simulates the flipping of a coin 100 times and tracks the longest streak of either heads or tails.

## Script Description

The script uses a `Random` object to simulate the flipping of a coin. It then checks if the current flip is the same as the last flip. If it is, it increments a streak counter. If it's not, it resets the streak counter to 1. The result of each flip and the current streak count are printed to the console.

## Imported Libraries

### java.util.Random

The `java.util.Random` class is a utility class in Java that generates pseudo-random numbers. In this script, it is used to simulate the flipping of a coin. The `nextInt(2)` method is used, which returns a pseudo-random, uniformly distributed int value between 0 (inclusive) and the specified value (exclusive), in this case 2, simulating the two possible outcomes of a coin flip: heads or tails.

---
