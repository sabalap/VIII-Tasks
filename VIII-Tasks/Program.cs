// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        //შექმენით ორი დამოუკიდებელი კლასი(Parent, child).
        // Parent კლასში დაწერეთ მეთოდი, რომელიც გამოითვლის კონსოლიდან შეყვანილი რიცხვების ნამრავლს.
        // Child კლასს მემკვიდრეობით უნდა გამოეცეს ეს მეთოდი.კონსოლზე გამოიტანეთ შესაბამისი მნიშნელობა.
        Child child = new Child();
        child.Multiply();

        Console.WriteLine("");

        /* შექმენით ერთი კლასი, რომელიც მემკვიდრეობით მიღებს ორ ველს: თქვენს სახელს და მისამართს.
         * თავის მხრივ, ამ კლასს უნდა ჰქონდეს ორი ველი დაბადების თარიღი და ასაკი.შედეგები გამოიტანეთ კონსოლზე.*/
        BirthDateAge person = new BirthDateAge();
        person.Name = "Saba";
        person.Address = "Tbilisi";
        person.BirthDate = "2000/02/15";
        person.Age = 23;
        person.PersonInfo();

        Console.WriteLine("");

        //შექმენით სამი კლასი, სამი ობიექტი. ყველას უნდა ჰქონდეს ერთი საერთო მახასიათებელი
        //პირადი ნომერი და რაიმე უნიკალური კოდი, რომელსაც მიიღებენ მშობელი კლასიდან.
        //თავის მხრივ ამ კლასებს უნდა ჰქონდეთ განსხვავებული ველები: პირველ კლასს სახელი და მისამართი,
        //მეორე კლასს ასაკი და დაბადების თარიღი, მესამე კლასს ქვეყანა და ქალაქი.
        //კონსოლზე გამოიტანეთ დაწყვილებული ინფორმაცია, პირველი კლასის ცალკე, მეორესი ცალკე და ა.შ.


        PersonNameAndAddress person2 = new PersonNameAndAddress(01006050340,"asdsaas1231212","Saba","Tbilisi Georgia");
        person2.PersonInfo();

        Console.WriteLine("");

        PersonAgeAndBirthDate person3 = new PersonAgeAndBirthDate(01236050340, "sdasdasdsad213", "2000/02/15", 23);
        person3.PersonInfo();

        Console.WriteLine("");

        CountryAndCity country = new CountryAndCity(01116000340, "sdaavhhfsad17", "USA", "NYC");
        country.CountryInfo();
    }
}

//შექმენით ორი დამოუკიდებელი კლასი(Parent, child).
// Parent კლასში დაწერეთ მეთოდი, რომელიც გამოითვლის კონსოლიდან შეყვანილი რიცხვების ნამრავლს.
// Child კლასს მემკვიდრეობით უნდა გამოეცეს ეს მეთოდი.კონსოლზე გამოიტანეთ შესაბამისი მნიშნელობა.
public class Parent
{
    public void Multiply()
    {
        Console.WriteLine("Please Enter the First Number");
        int number1 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter the Second Number");
        int number2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Multiply Result is");

        Console.WriteLine(number1 * number2);
    }
}

public class Child : Parent
{
}


/* შექმენით ერთი კლასი, რომელიც მემკვიდრეობით მიღებს ორ ველს: თქვენს სახელს და მისამართს.
       * თავის მხრივ, ამ კლასს უნდა ჰქონდეს ორი ველი დაბადების თარიღი და ასაკი.შედეგები გამოიტანეთ კონსოლზე.*/
public class NameAddress
{
    public string Name { get; set; }
    public string Address { get; set; }
}

public class BirthDateAge : NameAddress
{
    public string BirthDate { get; set; }
    public int Age { get; set; }

    public void PersonInfo()
    {
        Console.WriteLine($"person name is {Name}, {Name}'s birth date is {BirthDate}, {Name} is {Age} years old and address is {Address}");
    }
}


//შექმენით სამი კლასი, სამი ობიექტი. ყველას უნდა ჰქონდეს ერთი საერთო მახასიათებელი
//პირადი ნომერი და რაიმე უნიკალური კოდი, რომელსაც მიიღებენ მშობელი კლასიდან.
//თავის მხრივ ამ კლასებს უნდა ჰქონდეთ განსხვავებული ველები: პირველ კლასს სახელი და მისამართი,
//მეორე კლასს ასაკი და დაბადების თარიღი, მესამე კლასს ქვეყანა და ქალაქი.
//კონსოლზე გამოიტანეთ დაწყვილებული ინფორმაცია, პირველი კლასის ცალკე, მეორესი ცალკე და ა.შ.
class PersonalIdentification
{
    public int Id { get; set; }
    public string UniqueCode { get; set; }
    public PersonalIdentification(int id, string uniqueCode)
    {
        Id = id;
        UniqueCode = uniqueCode;
    }
}

class PersonNameAndAddress : PersonalIdentification
{
    public string Name { get; set; }
    public string Address { get; set; }

    public PersonNameAndAddress(int id, string uniqueCode, string name, string address) : base(id, uniqueCode)
    {
        Name = name;
        Address = address;
    }

    public void PersonInfo()
    {
        Console.WriteLine($"Name - {Name}, Address - {Address}, Id - {Id}, UniqueCode - {UniqueCode}");
    }
}

class PersonAgeAndBirthDate : PersonalIdentification
{
    public string BirthDate { get; set; }
    public int Age { get; set; }

    public PersonAgeAndBirthDate(int id, string uniqueCode, string birthDate, int age) : base(id, uniqueCode)
    {
        BirthDate = birthDate;
        Age = age;
    }

    public void PersonInfo()
    {
        Console.WriteLine($"BirthDate - {BirthDate}, Age - {Age}, Id - {Id}, UniqueCode - {UniqueCode}");
    }
}

class CountryAndCity : PersonalIdentification
{
    public string Country { get; set; }
    public string City { get; set; }

    public CountryAndCity(int id, string uniqueCode, string country, string city) : base(id, uniqueCode)
    {
        Country = country;
        City = city;
    }

    public void CountryInfo()
    {
        Console.WriteLine($"Country - {Country}, City - {City}, Id - {Id}, UniqueCode - {UniqueCode}");
    }
}