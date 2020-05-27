using System;
using System.Collections.Generic;
using System.Linq;




namespace BlackJackFinal
{
    class Program
    {

        static void Main(string[] args)




        {
         private int playerCardValue = 0;
        private int dealerCardValue = 0;

            switch (playerCardValue, dealerCardValue)
            {
                case "Ace":
                    return 11;
                case 2:
                    Console.WriteLine("2 Card");
                    return 2;
                case 3:
                    Console.WriteLine("3 card");
                    return 3;
                    break;
                   
                case 5:
                    Console.WriteLine("5 card");
                    return 5;
                    break;
                case 6;
                    Console.WriteLine("6 card");
                    return 6;
                    break;
                case 7:
                    Console.WriteLine("7 card");
                    return 7;
                    break;
                case 8:
                    Console.WriteLine("8 card");
                    return 8;
                    break;
                case 9:
                    Console.WriteLine("9 Card");
                    return 9
                    break;
                case 10:
                    Console.WriteLine("10, Jack, Queen, King");
                    return 10;
                    break;
            }
}



internal struct NewStruct
{
    [NullableAttribute(1)]
    public object Item1;
    [NullableAttribute(1)]
    public object Item2;

    public NewStruct(object item1, object item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct other &&
               EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
               EqualityComparer<object>.Default.Equals(Item2, other.Item2);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Item1, Item2);
    }

    public void Deconstruct(out object item1, out object item2)
    {
        item1 = Item1;
        item2 = Item2;
    }

    public static implicit operator (object, object)(NewStruct value)
    {
        return (value.Item1, value.Item2);
    }

    public static implicit operator NewStruct((object, object) value)
    {
        return new NewStruct(value.Item1, value.Item2);
    }
}








//Random Number from deck because of card value
Random random = new Random();
{


playerCardValue += random.Next(1, 12);
        
    playerCardValue += random.Next(1, 12);

            if (playerCardValue > 21)
            {
                playerCardValue -= 10;
            }

    dealerCardValue += random.Next(1, 12);
            dealerCardValue += random.Next(1, 12);
}

            //So no one busts

            if (dealerCardValue > 21)
            {
                dealerCardValue == 10;

            }
            //Player

            while (true)
            {
                if (playerCardValue == 21)
                {
                    Console.WriteLine("Congrats on 21!");
                    break;

                }
                Console.WriteLine("Your Card Value: " + playerCardValue.ToString() + "Hit again?");
            }


                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    //To hit again
                    playerCardValue += random.Next(1, 12);

                    if (playerCardValue > 21)
                    {
                        Console.WriteLine("You've gone over 21");
                        break;

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (answer == "n")
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Try Again");
                    }
            }
    

                    //Continue will continue loop
                    continue;
                

            
    

            //Dealer
            Console.WriteLine("Players Card Value is " + playersCardValue.ToString());

            if (playerCardValue <= 21)
            {
                while (dealerCardValue< 21 && dealersCardValue<playerCardValue)
                {
                    dealerCardValue += random.Next(1, 12);
                }

                //Check For Winner
                if (playerCardValue == dealerCardValue)
                {
                    Console.WriteLine("Player and Dealer have tied");
                }

                else if (playerCardValue<dealerCardValue && dealerCardValue <= 21)
                {
                    Console.WriteLine("The Dealer Has Won");
                }
                else if (dearlersCardValue > 21)
                {
                    Console.WriteLine("Dealer has busted, You've won!");
                }

                else if (dealersCardValue == 21)
                {
                    Console.WriteLine("The dealer has won :(");

                }

            
            else
            {
                Console.WriteLine("Dealer has won the game");
            }
            
                



            

        








