using WarriorsDuel.Classes;

void Combat(Warrior warriorOne, Warrior warriorTwo)
{
    int turn = 1;

    while (warriorOne.Hp > 0 && warriorTwo.Hp > 0)
    {
        Console.WriteLine("|-----------------------------|");
        Console.WriteLine($"\t Turn : {turn}");
        Console.WriteLine("|-----------------------------| \n");

        if (turn%2 == 0)
        {
            for (int i = 0; i < warriorTwo.NbAttacks; i++)
            {
                

                if (warriorOne.Hp > 0)
                {
                    int dmg = warriorTwo.Attack();
                    warriorOne.Hp -= warriorOne.ReceiveDmg(dmg);

                    if (warriorOne.Hp < 0)
                    {
                        warriorOne.Hp = 0;
                    }

                    Console.WriteLine($"{warriorTwo.Name} inflicts {dmg} !");
                    if(warriorOne.Armor > 0)
                    {
                        Console.WriteLine($"The armor of {warriorOne.Name} deflect {warriorOne.Armor} damage(s) ! \n");
                    }
                    Console.WriteLine($"{warriorOne.Name} have {warriorOne.Hp} Hp left. \n");
                }
                
            }
        }
        else
        {

            for (int i = 0; i < warriorOne.NbAttacks; i++)
            {
               

                if(warriorTwo.Hp > 0)
                {
                    int dmg = warriorOne.Attack();
                    warriorTwo.Hp -= warriorTwo.ReceiveDmg(dmg);

                    if (warriorTwo.Hp < 0)
                    {
                        warriorTwo.Hp = 0;
                    }
                    

                    Console.WriteLine($"{warriorOne.Name} inflicts {dmg} !");
                    if (warriorTwo.Armor > 0)
                    {
                        Console.WriteLine($"The armor of {warriorTwo.Name} deflect {warriorTwo.Armor} damage(s) ! \n");
                    }
                    Console.WriteLine($"{warriorTwo.Name} have {warriorTwo.Hp} Hp left. \n");
                }
               
            }
        }

        turn++;
    }

    if( warriorOne.Hp > 0 )
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

Warrior friedrich = new Warrior("Friedrich", 20, 2);
Warrior sigismund = new Warrior("Sigismund", 25, 1);

Dwarf thorin = new Dwarf("Thorin", 25, 1, 3);
Elf legolas = new Elf("Legolas", 18, 3);

Combat(legolas, thorin);