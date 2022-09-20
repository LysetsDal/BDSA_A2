namespace Lib;


public class Student
{
    public int Id { get; init; }

    public string? GivenName { get; set; }

    public string? SurName { get; set; }

    public enum State
    {
        New,
        Active,
        Dropout,
        Graduated
    }
    public State Status
    {
        get
        {
            var now = DateTime.Now;
            if (now > StartDate && now < EndDate) return State.Active;
            if (EndDate < GraduationDate && now > EndDate) return State.Dropout;
            if (EndDate >= GraduationDate && now >= GraduationDate) return State.Graduated;
            return State.New;
        }
    }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime GraduationDate { get; set; }


    public Student(int _id, string _fname, string _lname, DateTime _start, DateTime _end, DateTime _grad)
    {
        Id = _id;
        GivenName = _fname;
        SurName = _lname;
        StartDate = _start;
        EndDate = _end;
        GraduationDate = _grad;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {GivenName} {SurName}";
    }

}
