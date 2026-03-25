Console.WriteLine("Please enter your age to proceed");
Random ticket_generetor = new Random();
int ticket_No = 0;
int client_Age= int.Parse(Console.ReadLine());
if (client_Age >= 18)
 {
   ticket_No= ticket_generetor.Next(1000, 9999);
    Console.WriteLine
     ("Thanks you for choosing our cinema. Here is your ticket no:" + ticket_No);
  }

else
 {
    Console.WriteLine
     ("Acscess Denied: You do not meet the minimum age requirement for this Movie");
 }

