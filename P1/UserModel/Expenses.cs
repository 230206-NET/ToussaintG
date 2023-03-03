using System;
namespace UserModel;


public class Expenses{


    public int uID{get; set; }

    public int expID;

    public decimal expenseAmount{get;set; }

    public string expenseName{get; set; }

    public DateTime expenseDate{get;set; } = DateTime.Now;

    public string approval{get; set; }

    public override string ToString()
    {
        return $"Expense Name: {this.expenseName}\nExpense Amount:{this.expenseAmount}\nApproval:{this.approval}";
    }






}