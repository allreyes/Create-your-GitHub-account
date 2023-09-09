


public enum Hello
{
    Instructor, AssistantProfessor, AssociateProfessor, Professor
}

public class Instructor
{
    public int instructorID { get; set; }
    public string instructorFirstName { get; set; }
    public string instructorLastName { get; set; }
    public string instructorIsTenured { get; set; }
    public string instructorEmail { get; set; }
    public Hello instructorRank { get; set; }
    public DateTime instructorDateHired { get; set; }


}