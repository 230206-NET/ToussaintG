// See https://aka.ms/new-console-template for more information


/*
This app will: 
-ask the user to input an initial budget
-ask the user thow many expenses they have and their descriptions
-subtract the expenses from the budget
-notify the user if they have gone over budget

*/


//*Introduction and set budget*


Console.WriteLine("Welcome to the Budget App");
Console.WriteLine("Please enter a your balance: ");
int balance = int.Parse(Console.ReadLine()!);



//**Set intial Array**
//Initial expense count

 
//At least One Bill to be paid
Console.WriteLine("How many bills do you have to pay?: ");

int numBills = int.Parse(Console.ReadLine()!);

//Expense Counter
int expenseCounter = 0;


Console.WriteLine("");







//Input and Create a list of expenses

//Array setup

//**Set an array**
Expense[] expArr = new Expense[numBills];

while(expArr.Length > expenseCounter ){
//Bill Description    
Console.WriteLine("Input expense: ");
string billName = Console.ReadLine()!;
Expense newBill = new Expense();
newBill.Description = billName;

//Bill Expense
Console.WriteLine("Input expense vaule: ");
int billValue = int.Parse(Console.ReadLine()!);
newBill.Bill = billValue;

expArr[expenseCounter] = newBill;

expenseCounter++;
}

int remainder = 0;
//Present the list of expenses
for(int i = 0; i < expArr.Length; i++){

    
    Console.WriteLine(expArr[i].Description + " " + expArr[i].Bill);
    remainder = balance - expArr[i].Bill;

}

 if(remainder >= 0){
            Console.WriteLine("You are on budget");
            Console.WriteLine("Your remaining budget: " + remainder);
        }
        else{
            Console.WriteLine("You are over-budget");
            Console.WriteLine("Your remaining budget: " + remainder);
        }
/*

//Resize the Array of Expenses
Expense[] ResizeArray(Expense[] arrToResize){

    Expense[] newArr = new Expense[arrToResize.Length * 2];
    for(int i = 0; i < arrToResize.Length; i++){
        newArr[i] = arrToResize[i];
    }
    return newArr;

}
*/

//**NEW CONCEPT** -- Records - Use to make an array detailing expenses
public record Expense
{
    public string Description{ set; get; } = "";
    public int Bill{ set; get; } 

};
