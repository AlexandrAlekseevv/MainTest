
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
