# Foxhound Control Panel

A Windows Forms application designed for managing challenges and bounty logs in Gmod PvP server i am apart of.

## Features

- **Random Challenge Generator**  
  Loads a list of challenges from an external text file and displays a random set of three unique challenges. 

- **Bounty Log Generator**  
  Input Crayons and Cigs amounts, and enter player names prefixed by their faction (`LVET` or `HECU`).  
  Generates formatted logs showing rewards:  
  - Crayons rewards apply to HECU players  
  - Cigs rewards apply to LVET players

- **Reward Calculator**  
  Dynamically calculates rewards based on user input and two multiplier checkboxes.

## Usage

1. Place `BP_Challenges.txt` in the same folder as the executable to load challenges.  
2. Enter the amount of Crayons and Cigs, then input unit names with faction prefixes (`LVET John`, `HECU Steve`, etc.) separated by new lines.  
3. Click **Generate Log** to see formatted reward logs split by faction.  
4. Use the calculator section to input base reward and enable multipliers to see the updated output live.

## Development

- Built with C# and Windows Forms.  
- UI elements and event handlers in `Form1.cs`.  
- Challenges are loaded from an external `.txt` file for easy editing.

## Notes

- Ensure the input format for units matches exactly (e.g., `LVET John`) for correct log generation.  
- Multiplier checkboxes stack multiplicatively (each doubles the base reward).

