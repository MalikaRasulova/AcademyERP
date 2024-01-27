namespace EPR_Academy.Domain;

public class Teacher : User
{
    public Group MyGroup { get; set; }
    public Subject Subject { get; set; }
    public IEnumerable<Agenda> Agendas { get; set; }
    public IEnumerable<Group> Groups { get; set; }
}