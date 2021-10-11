using System;
  
public class Encap {
 
    private String studentName;
    private int studentAge; 
  
    public String Name
    {
       get
        {
            return studentName;    
        }
          
        set 
        {
            studentName = value;
        }
          
    }
     
    public int Age
    {
          
        get 
        {
            return studentAge;    
        }
          
        set 
        {
            studentAge = value;
        }
          
    }
  
      
}
  

class encapsulation {
      
   
    static public void Main()
    {
          
        
        Encap obj = new Encap();
        obj.Name = "faheem";
         
        obj.Age = 21;
  
       
        Console.WriteLine("Name: " + obj.Name);
        Console.WriteLine("Age: " + obj.Age);
    }
}
