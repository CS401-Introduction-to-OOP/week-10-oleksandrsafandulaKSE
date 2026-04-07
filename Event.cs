namespace week_10_oleksandrsafandulaKSE;

public class Event
{
    public int Step { get; set; }
    
    public string Description { get; set; }
    
    public string Type { get; set; }
    
    public string ChangeCharacteristics { get; set; }

    public Event(int step, string description, string type, string changeCharacteristics)
    {
        Step = step;
        Description = description;
        Type = type;
        ChangeCharacteristics = changeCharacteristics;
    }


    public override string ToString()
    {
        return Step.ToString();
    }
}