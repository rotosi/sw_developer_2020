using System;

namespace Library
{
  public class Student
  {
    public string Name;
    public Guid Id;
    public DateTime Birthday;
    public StudentState State;
    public string SchoolName;
    public int NumberBooksBorrowed;

    //contructor
    public Student(string name, DateTime birthday, string schoolName, int numberBooksBorrowed)
    {
      Id = Guid.NewGuid();
      State = StudentState.reachedMaxNumberBooksborrowed;

      Name = name;
      Birthday = birthday;
      SchoolName = schoolName;
      NumberBooksBorrowed = numberBooksBorrowed;
    }

    public void DisplayInfos()
    {
      Console.WriteLine($"MA Id:    {Id}");
      Console.WriteLine($"Name:     {Name}");
      Console.WriteLine($"Birthday: {Birthday.ToLongDateString()}");
      Console.WriteLine($"State:    {State}");
      Console.WriteLine($"SchoolName: {SchoolName}");
      Console.WriteLine($"NumberBookBorrowed: {NumberBooksBorrowed}");
      Console.WriteLine();
    }

    public void SchoolName();


  }

}