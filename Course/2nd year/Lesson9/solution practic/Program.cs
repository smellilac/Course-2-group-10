namespace base1
{
    class main
    {
        public static void Main(string[] args)
        { 
            Person pers1 = new Person(10,"Tom");
            Person pers2 = new Person(99,"Eger");
            Person pers3 = new Person(-45,"Znif");
            Person pers4 = new Person(21,"David");
            Person[] pers = {pers1,pers2,pers3,pers4};
            foreach (Person person in pers)
            { 
                person.Introduce();
            }
        }

        
    }  
}
class Person
{
    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    
    }
    public int Age
    {
        set
        {
            if (value < 1 || value > 120)
                Console.WriteLine("Возраст должен быть в диапазоне от 1 до 120");
            else
                age = value;
        }
        get { return age; }
    }
    public int age = 1;
    public string? Name;
    public void Introduce() => Console.WriteLine($"Привет, мое имя{Name}");

}
class Employee : Person
{
    public Employee(int age, string name, string position) : base(age, name)
    {
        Position = position;
    }
    public string Position { get; set; } 
}