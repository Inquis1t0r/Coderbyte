using System;
/*Your program should return the number of ways 2 students can be seated next to each other*/

class MainClass {

  public static int ArrayChallenge(int[] arr) {

    int classRows = arr[0]/2;
    int result = arr[0];
    int totalPossiblePlaces = (classRows - 1) * 2 + classRows; 

    if(arr.Length == 1){
      result = arr[0];
    }

    for(int i = 0; i < arr.Length; i++){
      bool neighbours = arr[i] % 2 == 0 && i > 1 && arr[i] - arr[i - 1] == 1;
      bool pararelNeighbours = (i > 1 && arr[i] - arr[i - 1] == 2) || (i > 2 && arr[i] == arr[i - 1] == 2);
      bool corner = arr[i] == 1 && arr[i] == 2 || arr[0];

      if(corner && (neighbours || pararelNeighbours))
      totalPossiblePlaces -=1;
    }
    result = totalPossiblePlaces;
    return result;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(ArrayChallenge(Console.ReadLine()));
  } 

}
