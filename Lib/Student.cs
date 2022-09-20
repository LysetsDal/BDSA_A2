namespace Lib;


public class Student
{
    public int Id { get; init; }

    public string? GivenName { get; set; }

    public string? SurName { get; set; }

    public enum _Status
    {
        New,
        Active,
        Dropout,
        Graduated
    }
    public _Status Status
    {
        get
        {

            return _Status.Active;

        }

    }



    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime GraduationDate { get; set; }


    public Student(int _id, string _fname, string _lname)
    {
        Id = _id;
        GivenName = _fname;
        SurName = _lname;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {GivenName} {SurName}";
    }

}
