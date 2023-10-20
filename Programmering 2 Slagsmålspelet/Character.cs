public class Character
{
    public string name;
    public int health = 75;
    public Weapon weapon;

    public void Attack(Character enemy)
    {
        int damage = weapon.WeaponDamage();
        enemy.health -= damage;
        enemy.health = Math.Max(0, enemy.health);

        Console.WriteLine($"{name} quickly attacks {enemy.name} with {weapon.name} doing {damage} HP ");
    }

}