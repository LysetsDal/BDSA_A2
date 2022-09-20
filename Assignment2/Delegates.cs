
namespace Assignment2;

public class Delegates
{

    public IEnumerable<T> CustomReverse<T>(IEnumerable<T> str)
    {
        foreach (var item in str.Reverse())
        {
            yield return item;
        }
    }

    public double ProductNums(double a, double b) => a * b;

    // A method which takes a whole number and a string and returns true if they are
    // numerically equal. Note that the string " 0042" should return true if the number is 42

    public bool NumericalEqual(int num, string str)
     => str.All(char.IsDigit) && num.Equals(int.Parse(str));

}