/*
    The goal is to find fraudulent orders as early as possible and flag them for deeper analysis.
    Orders starting with the letter "B" encounter fraud at a rate 25 times the normal rate.
*/
string[] code = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
int count=0;

foreach(string item in code){
    count++;

    if (item.StartsWith("B"))
    {
        Console.WriteLine($"The item {count} with the code {item} contains fraud");
    }

}
