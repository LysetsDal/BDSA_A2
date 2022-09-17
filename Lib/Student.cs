namespace Lib;
public class Student
{
    public int Id { get; init; }

    public string GivenName { get; set; }

    public string SurName { get; set; }

    public enum Status
    {
        New,
        Active,
        Dropout,
        Graduated
    }

    public DateTime StartDate { get; set; } 

    public DateTime EndDate { get; set; }

    public DateTime GraduationDate { get; set; }


}
