using WarriorsDuel.Classes;

void Combat(Warrior warriorOne, Warrior warriorTwo)
{
    int turn = 1;

    while (warriorOne.Pv > 0 && warriorTwo.Pv > 0)
    {
        Console.WriteLine($"Turn : {turn}");

        if (turn%2 == 0)
        {
            for (int i = 0; i < warriorTwo.NbAttacks; i++)
            {
                

                if (warriorOne.Pv > 0)
                {
                    int dmg = new Random().Next(1, 7);

                    warriorOne.Pv -= dmg;
                    if (warriorOne.Pv < 0)
                    {
                        warriorOne.Pv = 0;
                    }

                    Console.WriteLine($"{warriorTwo.Name} inflicts {dmg} !");
                    Console.WriteLine($"{warriorOne.Name} have {warriorOne.Pv} left. \n");
                }
                
            }
        }
        else
        {

            for (int i = 0; i < warriorOne.NbAttacks; i++)
            {
               

                if(warriorTwo.Pv > 0)
                {
                    int dmg = new Random().Next(1, 7);
                    warriorTwo.Pv -= dmg;
                    if (warriorTwo.Pv < 0)
                    {
                        warriorTwo.Pv = 0;
                    }
                    

                    Console.WriteLine($"{warriorOne.Name} inflicts {dmg} !");
                    Console.WriteLine($"{warriorTwo.Name} have {warriorTwo.Pv} left. \n");
                }
               
            }
        }

        turn++;
    }

    if( warriorOne.Pv > 0 )
    {
        Console.WriteLine($"{warriorTwo.Name} is vanquished ! \n");
        Console.WriteLine($"{warriorOne.Name} Win !");
    }
    else
    {
        Console.WriteLine($"{warriorOne.Name} is vanquished ! \n");
        Console.WriteLine($"{warriorTwo.Name} Win !");
    }

}

Warrior friedrich = new Warrior("Friedrich", 10, 2);
Warrior sigismund = new Warrior("Sigismund", 15, 1);

Combat(friedrich, sigismund);