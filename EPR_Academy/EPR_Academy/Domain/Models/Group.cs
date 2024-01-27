namespace EPR_Academy.Domain;

public class Group : BaseModel
{
    public string Name { get; set; }
    public Teacher Curator { get; set; }
    public IEnumerable<Student> Students { get; set; }
    
}