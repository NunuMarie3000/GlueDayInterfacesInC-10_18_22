namespace InterfacesInCSharp.Interfaces
{
  public interface IAttack
  {
    string SignatureMove { get; set; }
    string Alternate { get; set; }

    int LightAttack();
    void Taunt();
    int StrongAttack();
    int Jump();
    int Parry();
  }
}