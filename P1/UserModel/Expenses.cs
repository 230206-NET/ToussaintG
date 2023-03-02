namespace UserModel;


public class Expenses{


    public int uID{get; set; }

    public int expID;

    public double expenseAmount{get;set; }

    public string expenseName{get; set; }

    public DateTime expenseDate{get;set; } = DateTime.Now;

    public string approval;

    public override string ToString()
    {
        return $"Expense Name: {this.expenseName}\nExpense AMount:{this.expenseAmount}";
    }






}