# Spotless Plugin for Supermarket Simulator

**Spotless Plugin** removes garbage spawn and dusting from the game, creating a cleaner, more enjoyable supermarket experience. This plugin gives you control over two key features: garbage spawning (which includes dirt) and dusting, allowing you to disable them if you prefer a tidier environment.

## Features

- **Disable Garbage Spawn**: Prevents garbage and dirt from spawning in the supermarket, keeping your store clean and tidy.
- **Disable Dusting**: Removes the dusting mechanic, so you don't have to worry about cleaning up the shelves.

## Types of Garbage in the Game

The game generates several types of garbage that can now be disabled with this plugin:

- **Normal Garbage**: Trash items that can be picked up and packed into garbage bags.  
- **Dirt**: Floor messes (considered garbage in-game) that can be cleaned using a mop.  
- **Dust**: Appears on window glass and can be cleaned with a sponge.  

## Important Note: Existing Garbage

⚠ **Warning**: The plugin does not remove garbage that was already generated before the plugin was installed. You will need to clean up any existing garbage, dirt, or dust manually. Once cleaned, no new garbage will spawn while the plugin is active.

## Configuration

The plugin provides configuration options that can be adjusted in the `BepInEx/config` folder:

- **SpawnGarbage**: Set to `false` to disable garbage (including dirt) spawning (default: `false`).
- **Dusting**: Set to `false` to disable dusting mechanics (default: `false`).