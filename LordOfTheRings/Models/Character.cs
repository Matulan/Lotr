namespace LordOfTheRings.Components;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Height { get; set; }
    public string Hair_Color { get; set; }
    public string Eye_Color { get; set; }
    public string Date_Of_Birth { get; set; }
    public string Date_Of_Death { get; set; }
    public string Gender { get; set; }
    public string Species { get; set; }
    public string Race { get; set; }
    public string Group { get; set; }
    
    public List<string> Weapons { get; set; }
    public string Realm { get; set; } 

    public List<string> Languages { get; set; }
    public List<string> Films { get; set; }
    public List<string> Books { get; set; }
    
    public string Url { get; set; }
}