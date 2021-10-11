using System;
namespace ConsoleApplication1 {
  
class inheritance{
   
 
    public string name;
    public string subject;
  
    / 
    public void readers(string name, string subject)
    {
        this.name = name;
        this.subject = subject;
        Console.WriteLine("Myself: " + name); 
        Console.WriteLine("My Favorite Subject is: " + subject);
    }
}
  
// inheriting the inheritance class using : 
class main_part : inheritance{
   
   
    public main_part()
    {
        Console.WriteLine("main-part");
    }
}
   
// Driver class
class Sudo {
  
   
    static void Main(string[] args)
    {
   
        // creating object of derived class
       main_part g = main_part();
  
         
       
        g.readers("faheem", "bridgelab");
    }
}
}
