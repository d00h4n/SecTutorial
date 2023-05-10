class Cat
{
    //Variable
    public int age;
    public string name;
    public string race;
    private int _salary;
    
    //Constructor
    public Cat() {}
    public Cat(string a,  int b, int c) {
        name = a;
        age = b;
        _salary = c;
    }

    //Method
    public void Eat() {
        Console.WriteLine("Cat Eat");
    }

    public void Sleep() {
        Console.WriteLine("Cat Sleep");
    }
    
    //Method with Parameter
    public void SetSalary(int x) {
        _salary = x;
    }
    
    public int GetSalary() {
        return _salary;
    }
   

// Getter and setter


class Bird
{
  public string name   
  
  { get; set; }
  
}

class Program {
 static void Main(string[] args)
  {
    Bird Belang = new Bird();
    Belang.name = "Belang";
    Console.WriteLine(Belang.name);
}
}

// // Getter and setter Private

class Person
{
  private string name  ;
  public int work;
  public int age;
  
  
    public string Name   // property
  {
    get { return name; }   // get method
    set { name = value; }  // set method
  }

}

 }