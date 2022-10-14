using InterfacesInCSharp.Interfaces;

namespace InterfacesInCSharp.Classes
{
  public class Kitty
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public int PowerLevel { get; set; }
    public string KittyType { get; set; }
    public Kitty(string name, int age, int powerlevel, string kittytype)
    {
      Name = name;
      Age = age;
      PowerLevel = powerlevel;
      KittyType = kittytype;
    }
  }

  public class Puppy
  {
    public string Name { get; set; }
    public int Age { get; set; }
    public int PowerLevel { get; set; }
    public string PuppyType { get; set; }
    public Puppy(string name, int age, int powerlevel, string puppytype)
    {
      Name = name;
      Age = age;
      PowerLevel = powerlevel;
      PuppyType = puppytype;
    }
  }
}