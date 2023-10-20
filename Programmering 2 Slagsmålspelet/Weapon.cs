public class Weapon
{
    public string name;
    private Random generator;

    public Weapon()
    {
        generator = new Random();
    }

    public int WeaponDamage()
    {
        return generator.Next(15, 25);
    }

}