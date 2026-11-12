List<string> Student = new List<string>()
{
    "fazel",
    "reza",
    "raz",
    "fazel",
    "naz",
    "Ebrahim",
    "Naz",
    "Aslan"
};
//Student.Sort();


//Console.WriteLine(Student.BinarySearch("raz"));

/*bool hazer = Student.Contains("fazel");
if (hazer)
{
    Console.WriteLine(Student.IndexOf("fazel"));
}*/


//List<string> unique=Student.Distinct().ToList();


foreach (var student in Student)
{
    Console.WriteLine(student.ToLower());
}