string[] array = { "123", ":-)", "Monaco", "Ufa", "Moskow", "Ural" };

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(array);


string [] ArraystringsThreeCharacters (string [] arr){
    string [] newArray = {};
    int j = 0;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
           Array.Resize(ref newArray, j+1);
           newArray[j] = arr[i];
           j++;
        }
    }
    return newArray;
}
array = ArraystringsThreeCharacters (array);
PrintArray(array);