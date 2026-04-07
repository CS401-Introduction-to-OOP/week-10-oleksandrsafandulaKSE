namespace week_10_oleksandrsafandulaKSE;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public string Role { get; set; }
    
    public int Level { get; set; }
    
    public int Health { get; set; }
    
    public int Gold { get; set; }
    
    public string Condition { get; set; }

    public Character(string name, string role, int lvl, int health, int gold, string condition)
    {
        Name = name;
        Role = role;
        Level = lvl;
        Health = health;
        Gold = gold;
        Condition = condition;
    }

    public override string ToString()
    {
        return Name;
    }
}