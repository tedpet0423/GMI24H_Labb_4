namespace GMI24H_Labb_4;

public class Person
{
  private string _name;
  private int _id;
  private string _profession;

  public Person(string name, int id, string profession)
  {
    _name = name;
    _id = id;
    _profession = profession;
  }

  public override string ToString()
  {
    return $"{_name},{_id},{_profession}";
  }

}