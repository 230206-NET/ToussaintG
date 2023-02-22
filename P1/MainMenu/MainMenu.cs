//Move all to main prog
   

        Console.WriteLine("Expense Reimbursement Program");

        Console.WriteLine("");
        while(true){
            Console.WriteLine("What would you like to the do?");

            Console.WriteLine("[1]: Sign Up");
            Console.WriteLine("[2]: Request Reimbursement");
            Console.WriteLine("[3]: Review Requests");
            Console.WriteLine("[E]: Exit");

            string? input = console.ReadLine();

            if(input != null){

                switch (input){

                    case "1":
                    break;

                    case "2":
                    break;

                    case "3":
                    break;

                    case "e":
                    Console.WriteLine("Terminating Program.....");
                    Environment.Exit(0);
                    break;

                    default:
                    Console.WriteLine("Not a vaild input!");
                    Console.WriteLine("What would you like to the do?");
                    break;










                 }



            }

        }
   