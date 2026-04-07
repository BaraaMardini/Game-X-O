# ❌⭕ Tic-Tac-Toe Game (C# Windows Forms)

## 📖 Overview
This project is a **Tic-Tac-Toe (XO) Game** built using C# and Windows Forms.

It allows two players to play interactively on a graphical interface, with automatic win detection and game state control.

---

## 🚀 Features
- 🎮 Two-player gameplay (Player1 vs Player2)
- 🔄 Turn-based system (X / O)
- 🧠 Automatic win detection
- 🚫 Prevent invalid moves (same cell cannot be selected twice)
- 🏁 Display winner or draw status
- 🔁 Reset game functionality
- 🎨 Visual feedback using images

---

## 🧱 Technologies & Concepts
- **C#**
- **Windows Forms (WinForms)**
- **Event-Driven Programming**
- **Game Logic Implementation**
- **State Management**

---

## 🏗️ System Design

### 🔹 Game Board
- 3x3 grid using PictureBoxes
- Each cell stores its state (X, O, or empty)

### 🔹 Game Logic
- Tracks player turns
- Checks all winning combinations:
  - Rows
  - Columns
  - Diagonals

### 🔹 UI Handling
- Updates images dynamically
- Displays current player and winner
- Disables board when game ends

---

## ⚙️ How It Works

1. Player1 starts the game.
2. Players take turns clicking on empty cells.
3. Each move:
   - Updates the board
   - Switches player turn
4. System checks for a winner after each move.
5. When a player wins:
   - Game stops
   - Winner is displayed
6. Reset button restarts the game.

---

## ▶️ Example Use Case
- Simple desktop game for two players using a graphical interface.

---

## 📊 What I Learned
- Implementing game logic in GUI applications
- Managing application state across multiple UI elements
- Handling user interactions with validation
- Designing interactive desktop games

---

## 📌 Future Improvements
- Refactor code to reduce repetition
- Use arrays or data structures instead of individual variables
- Add single-player mode (AI)
- Improve UI design and animations
- Apply Object-Oriented Design

---
