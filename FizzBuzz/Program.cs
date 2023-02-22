// See https://aka.ms/new-console-template for more information
NumEnter:
Console.WriteLine("Enter a positive integer: ");

//Read User Input via Console.ReadLine method, which returns String


String userInput = Console.ReadLine();
int parsedInput = int.Parse(userInput);
//Exception HAndling
//Wrap the code that may throw exception in the try block

	try
	{
		

		Console.WriteLine(parsedInput);
	}
	catch(FormatException)
	{
		Console.WriteLine("The input must be an integer");
		goto NumEnter;
	}
	catch(ArgumentNullException)
	{

		Console.WriteLine("You didn't input anything.....");

	}
	catch(OverflowException)
	{

		Console.WriteLine("ERROR ERROR");

	}

	finally
	{

		Console.WriteLine("Clean up some things");

	}
	Console.WriteLine("Some stuff outside");

	if(parsedInput <= 0){
		Console.WriteLine("Your input must be greater than zero");
		goto NumEnter;
	}

	for(int i = 1; i <= parsedInput; i++){
		if((i % 3 == 0) && (i % 5 == 0)){
			Console.WriteLine("FizzBuzz");
		}
		else if(i % 3 == 0){
			Console.WriteLine("Fizz");
		}
		else if(i % 5 == 0){
			Console.WriteLine("Buzz");
		}
		
		else{
			Console.WriteLine(i);
		}

	}