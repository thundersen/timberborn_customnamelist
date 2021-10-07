# Custom Name List for Timberborn

This is a very simple mod for the game [Timberborn by Mechanistry](https://mechanistry.com/).

It allows defining a custom name list, which will be used exclusively for naming your beavers.

Place a text file named `names.txt` in the same directory as `Timberborn.exe`.
`names.txt` should contain one line per name that you want to see in your game.

Names are picked from the list at random. Once all names have been used up, the list gets shuffled and names will be reused.

If the mod is active but can't find `names.txt` in the correct place, it will print an error message to the log and fall back to standard in-game names. 

## Installation

This mod is based on `BepInEx`. So you need to install that first: https://docs.bepinex.dev/articles/user_guide/installation/index.html

[Download](https://github.com/thundersen/timberborn_customnamelist/releases) the latest release of the mod and place `CustomNameList.dll` in your BepinEx plugin folder.

Place a `name.txt` file next to your `Timberborn.exe`.