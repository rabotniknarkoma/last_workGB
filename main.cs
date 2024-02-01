using System;

class Program
{
    static void Main() {
        int n = 5, count = 0;
        string[] array = new string[n];
        
        for (int i = 0; i < n; i++) {
            array[i] = Console.ReadLine();
            if (array[i].Length <= 3) {
                count++;
            }
        }
        
        string[] new_array = new string[count];
        int j = 0;
        
        for (int i = 0; i < n; i++) {
            if (array[i].Length <= 3) {
                new_array[j] = array[i];
                j++;
            }
        }
        
        var word = string.Join(" ", new_array);
        Console.WriteLine(word);
    }
}