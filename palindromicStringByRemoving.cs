using System;

/* if it is possible to create a palindromic string of minimum length 3 characters by removing 1 or 2 characters */

class MainClass {

  public static string StringChallenge(string str) {

    // code goes here  
    string result = "not possible"
    char values = str.ToCharArray();

    for(int i = 0; i < str.Length / 2; i++){
      if(values[i] != values.Length - 1 - i)
      result = "palindrome";
    }

    return result;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(StringChallenge(Console.ReadLine()));
  } 

}
