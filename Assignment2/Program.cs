// foreach (var wizard in WizardCollection.Create())
// {
//     Console.WriteLine(wizard);
// }
var now = DateTime.Now;
var student = new Student(1, "Nicolai", "Friis", now, now.AddYears(3), now.AddYears(3));

WriteLine(student.ToString());
