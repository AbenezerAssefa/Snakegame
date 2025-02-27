# 📌 Snake Game - Clean Code Refactored 🐍

This repository contains a **refactored** version of the classic **Snake Game**, adhering to **Clean Code principles** for better readability, maintainability, and scalability.

## 📖 Table of Contents
- [Features](#features)
- [Clean Code Principles Applied](#clean-code-principles-applied)
- [Installation & Setup](#installation--setup)
- [How to Play](#how-to-play)
- [License](#license)

## ✨ Features
✔️ **Difficulty Levels** - Choose from **Easy, Medium, and Hard** for different speeds.  
✔️ **Game Replay Option** - Retry after a **game over** without restarting the program.  
✔️ **Encapsulation & Modularity** - Organized into **separate classes** for better maintainability.  
✔️ **Improved Input Handling** - Dedicated method for **keyboard input processing**.  
✔️ **Better Collision Handling** - Snake and berry collisions managed efficiently.

## 🛠 Clean Code Principles Applied

### 1️⃣ Meaningful Names
- Variables, methods, and classes have **descriptive and intuitive** names.
- Example: `pixel` replaced with **`Snake`** and **`Berry`** classes for better clarity.

### 2️⃣ Divide Code into Methods
- Large code blocks refactored into **smaller, self-contained methods**.
- Example: Methods like `CollidesWith()`, `HandleInput()`, `Move()`, and `Draw()` improve modularity.

### 3️⃣ Divide Code into Classes
- Code is split into **multiple classes** for better organization:
  - **`Snake.cs`** - Manages snake movement and collision detection.
  - **`Berry.cs`** - Handles berry generation and collisions.
  - **`Game.cs`** - Controls the game loop and difficulty settings.
  - **`Program.cs`** - Manages game execution.

## 🚀 Installation & Setup
1. Clone the repository:
   ```sh
   git clone https://github.com/AbenezerAssefa/SnakeGame.git
