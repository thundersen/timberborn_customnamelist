# Custom Name List

It allows defining a custom name list, which will be used exclusively for naming your beavers.

Place a text file named `names.txt` in the same directory as `Timberborn.exe`.
`names.txt` should contain one line per name that you want to see in your game.

Names are picked from the list at random. Once all names have been used up, the list gets shuffled and names will be reused.

If the mod is active but can't find `names.txt` in the correct place, it will print an error message to the log and fall back to standard in-game names. 

# Change Log

- 0.1.2
  - Fix: Adapt mod for experimental release from 2021/11/24.
    (The game changed the location and name of the naming service that the mod needs to modify.)

- 0.1.1
  - Minimal version based on names.txt