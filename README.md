# Expense Tracker (WinForms, C#)

## Project Overview
The **Expense Tracker** is a simple C# WinForms application that allows users to record their daily expenses.  
Users can enter an expense name and amount, see a running total, and save their data locally in a JSON file.  

---

## Features
- Add new expenses with a name and amount.
- Automatically calculate and display total spending.
- View all saved expenses in a list.
- Save and load expenses using a JSON file.

---

## File Structure
ExpenseTracker/
│
├── src/
│ ├── Program.cs
│ ├── MainForm.cs
│ ├── Expense.cs
│ ├── ExpenseService.cs
│
├── data/
│ └── expenses.json
│
├── README.md
└── Requirements.txt


---

##  Installation Instructions
1. **Clone the repository:**
   ```bash
   git clone https://github.com/SMutanga/ExpemseTracker.git
 2. Open in a terminal using cd ExpenseTracker
 3. Type dotnet run
 4. Open the application and start tracking your expenses!

 ---

 ## How Data is Stored
- Expenses are stored in a JSON file located at `data/expenses.json`.
- Each expense entry includes a name and amount.
- The application reads from and writes to this file to persist data.

---

## Known Issues / Limitations
- No user authentication; all data is stored locally.
- No customization options for currency or categories.
- No export functionality for reports.

---

## Debugging Summary
- Button not adding items: Ensure btnAdd_Click event is wired in Form1.Designer.cs.
- File not found error: Create the data folder before running or check the relative path.
- Invalid number input: Enter a valid decimal number, do not include a currency symbol.

---

## Credits and Acknowledgments
- Developed by Sannah Penelope Azuh Mutanga.