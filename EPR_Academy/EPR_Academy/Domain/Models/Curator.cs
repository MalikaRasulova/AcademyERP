namespace EPR_Academy.Domain;

public class Curator : User
{
    public Teacher? Teacher { get; set; }
    public Group Group { get; set; }
}