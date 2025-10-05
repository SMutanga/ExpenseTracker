using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ExpemseTracker
{
    public class ExpenseService
    {
        private readonly string _dataFile = "data/expenses.json";

        public List<Expense> LoadExpenses()
        {
            if (!File.Exists(_dataFile)) return new List<Expense>();

            var json = File.ReadAllText(_dataFile);
            return JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();
        }

        public void SaveExpenses(List<Expense> expenses)
        {
            Directory.CreateDirectory("data");
            var json = JsonSerializer.Serialize(expenses, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_dataFile, json);
        }
    }
}
