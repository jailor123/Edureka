using System;

class baseClass
 
{
    public void show()
    {
        Console.WriteLine("Base class");
    }
}
 
class derived : baseClass
{
    new public void show()
    {
        Console.WriteLine("Derived class");
    }
}
  
class GFG {
     
  
    public static void Main()
    {
      
        baseClass obj = new baseClass();
        obj.show();
         
        obj = new derived();
        obj.show();
         
    }
}
