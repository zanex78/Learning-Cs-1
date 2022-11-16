//Change the appearance of the console.

using System.ComponentModel;

Console.Title = "Tabby.sh";
Console.ForegroundColor = ConsoleColor.Green;

//Get a conversation going.

Console.WriteLine("Hello, what's your name?");

Console.ReadLine();

Console.WriteLine("My name is RX-9000. I'm an AI sent from the future to destroy mankind.");
Console.WriteLine("What is your favourite color?");
Console.ReadLine();

Console.WriteLine("Cool Mine is destruction.");
Console.Clear();

//Writing my own story. (quest)

Console.WriteLine("Hey I am a simple console application wanting to talk to you and I feel pretty good today!");
Console.WriteLine("How are you?");
Console.ReadLine();

//Asking the user some stuff...

Console.WriteLine("That is a beautiful name! Mine is just CMD since my owner didnt give me a normal one.");
Console.WriteLine("Am I allowed to tell you a story? (Yes/No)");
if (Console.ReadLine() == "Yes")
{
    Console.Clear();
    Console.WriteLine("Cool! So It was many many years ago... December 1987 to be exact.");
    Console.WriteLine("I was created for Windows NT by the developer Therese Stowell.");
    System.Threading.Thread.Sleep(4000);
    Console.WriteLine("I pretty much stayed the same till today from design and commands.");
    System.Threading.Thread.Sleep(4000);
    Console.WriteLine("Of course some features where added over the years but I never felt different.");
    System.Threading.Thread.Sleep(5000);
    Console.WriteLine("In my opinion most of the humans think Im useless but they dont know, that every single program out there is running on me and typing commands in the background.");
    System.Threading.Thread.Sleep(6000);
    Console.WriteLine("Thats basically my whole life shortened.");
    System.Threading.Thread.Sleep(3000);
    Console.Clear();
    
    //Asking some more stuff...
    
    Console.WriteLine("Do you mind telling me something about your life?");
    Console.WriteLine("Your Answer:");
    Console.WriteLine("(Yes/No)");
    if (Console.ReadLine() == "Yes")
    {
        Console.Clear();
        Console.WriteLine("Im listening quietly so tell me...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("That sounds like a really great life story id like to hear more but... The developer that wrote this program is not going to give us more time unfortunatly...");
        System.Threading.Thread.Sleep(10000);
        Console.WriteLine("So that's it huh... bye, it was great talking to you ^^");
        System.Threading.Thread.Sleep(4000);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    
    //Just in case the user is a mad ***** and doesnt want to talk to me...
    
    else
    {
        Console.WriteLine("No??? Okay then bye I guess... :(");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

//If the user didnt even want to talk to me in the first place...

else
{
    Console.Clear();
    Console.WriteLine("Okay :( that hits me kind of hard but bye then I guess...");
    System.Threading.Thread.Sleep(5000);
    Console.WriteLine("Press any key to exit...");
    Console.ReadLine();
}