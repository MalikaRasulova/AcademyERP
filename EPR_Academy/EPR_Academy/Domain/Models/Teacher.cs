namespace EPR_Academy.Domain;

public class Teacher
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string FatherName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Group MyGroup { get; set; }
    public Subject Subject { get; set; }
    public IEnumerable<Agenda> Agendas { get; set; }
    public IEnumerable<Group> Groups { get; set; }
}