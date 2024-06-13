namespace DictionaryPractice;

internal class Program {
    static void Main(string[] args) {
        List<Student> students = new List<Student>();
        students.Add(new Student { Id = 1,Name = "Fred" });
        students.Add(new Student { Id = 2,Name = "Wilma" });
        students.Add(new Student { Id = 3,Name = "Emily" });

        Dictionary<int,Student> StudentDictionary = new Dictionary<int,Student>();
        foreach(var student in students) {
            StudentDictionary.Add(student.Id,student);
        }
        var Wilma = StudentDictionary[2];
        Console.WriteLine($"Id: {Wilma.Id}, Name: {Wilma.Name}");
        /*Dictionary<int,string> dictionary = new Dictionary<int,string>();
        dictionary.Add(1,"one");
        dictionary.Add(22,"twenty-two");
        dictionary.Add(14,"Fourteen");*/
    }
}
internal class Student {
    public int Id {
        get; set;
    }
    public string Name {
        get; set;
    }
}