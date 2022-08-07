
using System; 
using static System.Console; 
Clear(); 

string [] StartArray =  { "Hello", "2", "World", "12 34","1567","-2","e2" ,"Neapol","EnD"} ;

WriteLine($"Массив заданый на старте выполнения: \n[{String.Join(",",StartArray)}]\n");
File.WriteAllText("input.txt",($"Массив заданый на старте выполнения: \n[{String.Join(",",StartArray)}]\n"));

string[] LessThanThreeArray = LessThanThree(StartArray);

WriteLine($"Массив сформированный из строк ,длинна которых меньше или равна 3 символов: \n[{String.Join(",",LessThanThreeArray)}]\n");

string [] LessThanThree(string[] array)
{
    
    int countLessThanThree = 0;
    for(int j=0;j<array.Length;j++)
    {
        if(array[j].Length<=3)
        {
            countLessThanThree++;
        }
    }
    string [] result = new string[countLessThanThree];
    int indNewArray=0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i].Length<=3)
        {
            result[indNewArray]=array[i];
            indNewArray++;
        }
    }
     return result;   
}
