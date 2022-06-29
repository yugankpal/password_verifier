using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
          Console.WriteLine ("Hello Mono World");
        string password ;
        Console.Write("Input a username: ");
        password = Console.ReadLine();
        if(password.Length == 0){
            Console.Write("password should not be null \n");
        }
        else if(password.Length < 8){
            Console.Write("password shiould be larger than 8 chars \n");
        }
        
        bool b = ValidatePassword(password);    
         Console.WriteLine("'{0}' is{1} a valid password", password, b ? "": "n't");
    }
    static bool ValidatePassword(string passWord)    
   {
       
       int validConditions = 0;     
      foreach(char c in passWord)    
      {    
         if (c >= 'a' && c <= 'z')    
         {    
            validConditions++;    
            break;    
         }     
      }     
      foreach(char c in passWord)    
      {    
         if (c >= 'A' && c <= 'Z')    
         {    
            validConditions++;    
            break;    
         }     
      }     
      if (validConditions == 0) return false;     
      foreach(char c in passWord)    
      {    
         if (c >= '0' && c <= '9')    
         {    
            validConditions++;    
            break;    
         }     
      } 
      if (validConditions == 3) return true;
     
      return false;
   }
}