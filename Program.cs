using System; 
using static System.Console; 
Clear(); 

string [] StartArray =  { "Hello", "2", "World", "12 34","1567","-2","e2" ,"Neapol","EnD"} ;

WriteLine($"Массив заданый на старте выполнения: \n[{String.Join(",",StartArray)}]\n");
File.WriteAllText("input.txt",($"Массив заданый на старте выполнения: \n[{String.Join(",",StartArray)}]\n"));