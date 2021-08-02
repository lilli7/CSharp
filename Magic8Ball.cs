using System;
class Magic8Ball
{
    public void menu()
    {

        Console.WriteLine("Enter an option:");
        Console.WriteLine("----------------");
        Console.WriteLine("1.Ask");
        Console.WriteLine("2.Play again");
        Console.WriteLine("3. Quit");
       
    }

    public void generateResponse()
    {
        //create 20 responses and have
        //random call a random response according to number
        Random rand = new Random();
        int answer = rand.Next(1,10);

        switch (answer)
        {
            case 1:
                Console.WriteLine("The fifty mannequin heads floating in the pool kind of freaked them out.");
                break;

            case 2:
                Console.WriteLine("It isn't difficult to do a handstand if you just stand on your hands.");
                break;

            case 3:
                Console.WriteLine("She looked at the masterpiece hanging in the museum but all she could think is that her five-year-old could do better.");
                break;
            case 4:
                Console.WriteLine("Karen believed all traffic laws should be obeyed except by herself.");
                break;
            case 5:
                Console.WriteLine("He loved eating his bananas in hot dog buns.");
                break;
            case 6:
                Console.WriteLine("The ants enjoyed the barbecue more than the family.");
                break;
            case 7:
                Console.WriteLine("She wore green lipstick like a fashion icon.");
                break;
            case 8:
                Console.WriteLine("Don't step on the broken glass.");
                break;
            case 9:
                Console.WriteLine("Situps are a terrible way to end your day.");
                break;
            case 10:
                Console.WriteLine("She can live her life however she wants as long as she listens to what I have to say.");
                break;
        }
    }
    static void main(string[]args)
    {
        string question;
        int option; 
        char play;
        menu();

         if(option != 3)
        {
            switch (option)
            {
                case 1:
                //ask user and collect question
                Console.WriteLine("Enter a question:");
                question = Console.ReadLine();
                Console.WriteLine("Thinking...");
                //then run console's random response
                generateResponse();
                break;

                case 2:
                Console.WriteLine("Would you like to play again? 'Y/N'");
                play = Console.ReadLine();
                if(play = 'Y')
                {
                    menu();
                }
                else
                {
                    option = 3;
                }
                break;

            }
        }

    }
}