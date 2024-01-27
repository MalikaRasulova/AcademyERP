namespace EPR_Academy.Domain;

public class Student : BaseModel
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string FatherName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public User Father { get; set; }
    public User Mather { get; set; }
    public DateTime BrithDateTime { get; set; }
    public IEnumerable<Subject> Subjects { get; set; }
    public IEnumerable<Agenda> Agendas { get; set; }
}