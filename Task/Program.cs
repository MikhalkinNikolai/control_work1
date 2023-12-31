string[] SecondArray(string[] array){
    string[] array1 = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            array1[count] = array[i];
            count++;
        }
    }
    return array1;
}

void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}" + " ");
    }
    Console.WriteLine();
}

string[] array = ["Hello","2","world",":-)","--"];
string[] secondArray = SecondArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(secondArray);