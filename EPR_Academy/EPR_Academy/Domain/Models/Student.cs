namespace EPR_Academy.Domain;

public class Student : User
{
    public User Father { get; set; }
    public User Mather { get; set; }
    public string Password { get; set; }
    public DateTime BrithDateTime { get; set; }
    public IEnumerable<Subject> Subjects { get; set; }
    public IEnumerable<Agenda> Agendas { get; set; }
}