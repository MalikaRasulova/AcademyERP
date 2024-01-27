namespace EPR_Academy.Domain;

public class Group : BaseModel
{
    public string Name { get; set; }
    public IEnumerable<Teacher> Teachers { get; set; }
    public IEnumerable<Student> Students { get; set; }
    
}