namespace RowData;

public class Person
{
    public string? firstName {get; set;}
    public string? lastName {get; set;} 
    public int height {get; set;}

    public override string ToString()
    {
        return $"{lastName}, {firstName} ({height} cm)";
    }
}
