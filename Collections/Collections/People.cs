namespace Collections;

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }

    public People(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
       return ($"{Name},{Age}");
    }
}