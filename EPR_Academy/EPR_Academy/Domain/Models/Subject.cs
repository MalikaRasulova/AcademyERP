namespace EPR_Academy.Domain;

public class Subject
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Teacher Teacher { get; set; }
    public int StudentAssessment { get; set; }
}