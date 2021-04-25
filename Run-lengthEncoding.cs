using System;

/* take the str parameter being passed and return a compressed version of the string using the Run-length encoding algorithm*/

class MainClass {

  public static string StringChallenge(string str) {
    string result = String.Empty;
    int dupCheck = 1;
    str = str + " "; 
    for(int i =0;i<str.Length-1;i++){
      if(str[i] == str[i +1]){
        dupCheck +=1;
      }else{
        result += dupCheck;
        result += str[i];
        dupCheck = 1;
      }
    }
    return result;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(StringChallenge(Console.ReadLine()));
  } 

}
