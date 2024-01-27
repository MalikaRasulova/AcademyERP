namespace EPR_Academy.Domain;

public class User : BaseModel
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public string FatherName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}