string[] cibiPreferiti = { "Pasta al pesto", "Pasta e patate", "Lasagne", "Spaghetti con le vongole", "Gomiti con uova e ricotta"};
Console.WriteLine("I miei cibi preferiti sono " +  cibiPreferiti.Length);

for (var i = 0;  i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

///Stampo il cibo nella prima posizione 
Console.WriteLine(cibiPreferiti[0]);

///Stampo il cibo nell'ultima posizione 
Console.WriteLine(cibiPreferiti[cibiPreferiti.Length - 1]);

///ciaonnfw

