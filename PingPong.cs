using System;
using System.Collections.Generic;

public class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter your number");
    string stringNumber= Console.ReadLine();
    int intNumber = int.Parse(stringNumber); 


    for( int index =1; index <= intNumber; index++)
    

    {
      if(index%5 ==0 && index%3 ==0)
      { 
        string indexString0 = index.ToString();
        indexString0 = "Ping Pong";
        Console.WriteLine(indexString0);
      }
      else if(index%3 ==0)
      { 
        string indexString = index.ToString();
        indexString = "Ping";
        Console.WriteLine(indexString);
      }
      else if(index%5 ==0)
      { 
        string indexString1 = index.ToString();
        indexString1 = "Pong";
        Console.WriteLine(indexString1);
      }
      else 
      {
        Console.WriteLine(index);
      }
      
    }
  }
}

