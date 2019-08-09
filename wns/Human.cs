namespace wns
{
  public class Human
  {
    public string Name = "bob";
    private int _strength;
    public int Strength
    {
      get
      {
        return _strength;
      }
      set
      {
        _strength = value;
      }
    }
    public int Intelligence { get; set; } = 3;
    public int Dexterity { get; set; } = 3;
    public int Health { get; set; } = 100;
    public Human()
    {
    }
    public Human(string name)
    {
      Name = name;
    }
    public Human(string name, int health)
    {
      Name = name;
      Health = health;
    }
    public Human(string name, int str, int intel, int dex, int hp)
    {
      Name = name;
      Strength = str;
      Intelligence = intel;
      Dexterity = dex;
      Health = hp;
    }
    public virtual int Attack(Human target)
    {

      int dmg = Strength * 3;
      target.Health -= dmg;
      System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
      return target.Health;
    }
  }
}