string name = "";
string travelerweapon = "";


Character traveler = new Character();
Character boss = new Character();

Console.WriteLine("Who dares oppose me?");
name = Console.ReadLine();

traveler.name = name;

System.Console.WriteLine("With what weapon do you think you even have a chance?");
traveler.weapon = new Weapon();
traveler.weapon.name = Console.ReadLine();

boss.name = "Shadow Wizard Money Gang";
boss.weapon = new Weapon();
boss.weapon.name = "Wand of Swaggery";




//------------------------------------------------------------------------
Random generator = new Random();
while (traveler.health > 0 && boss.health > 0)
{
   Console.Clear();
   Console.WriteLine($"{name} has {traveler.health}HP  I  {boss.name} has  {boss.health}HP");
   System.Console.WriteLine("");

   traveler.Attack(boss);
   boss.Attack(traveler);


   Console.WriteLine("Already tired? [ENTER TO PROCEED]");
   Console.WriteLine("");
   Console.ReadKey();
   Console.Clear();

}


//------------------------------------------------------------------------
if (traveler.health == 0)
{
   Console.WriteLine($"{name} says: You call this is a Boss? Easy.");
   System.Console.WriteLine($"{name} wins");
}
else if (boss.health == 0)
{
   Console.WriteLine($"{boss.name} says: Its cute you, {name} thought you even had a chance.");
   System.Console.WriteLine($"{boss.name} wins");
}
else 
{
   Console.WriteLine("Well this is dissapointing..");
}
Console.WriteLine("Press [ENTER} to close game.");
Console.ReadKey();
