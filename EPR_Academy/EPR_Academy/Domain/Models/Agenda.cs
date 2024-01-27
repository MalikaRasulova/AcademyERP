namespace EPR_Academy.Domain;

public class Agenda : BaseModel
{
    public DateTime Day { get; set; }
    public IEnumerator<Subject>? Subjects { get; set; }
    public Subject? ForTecherSubject { get; set; }
    public bool IsCome { get; set; }
}