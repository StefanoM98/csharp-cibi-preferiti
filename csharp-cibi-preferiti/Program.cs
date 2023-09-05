string[] cibiPreferiti = { "Pasta al pesto", "Pasta e patate", "Lasagne", "Spaghetti con le vongole", "Gomiti con uova e ricotta", "Margherita"};
Console.WriteLine($"I miei cibi preferiti sono {cibiPreferiti.Length} ");

for (var i = 0;  i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

///Stampo il cibo nella prima posizione 
Console.WriteLine($"Il cibo in assoluto preferito è: {cibiPreferiti[0]}");

///Stampo il cibo nell'ultima posizione 
Console.WriteLine($"Il cibo che preferisco meno è: {cibiPreferiti[cibiPreferiti.Length - 1]}");

///Stampo il cibo di metà classifica
Console.WriteLine($"Il cibo che preferisco a metà è: {cibiPreferiti[cibiPreferiti.Length / 2]}");

/// aggiungo un elemento alla lista in modo da stamparne due

for (var i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

Console.WriteLine($"I cibi che preferisco a metà sono: {cibiPreferiti[cibiPreferiti.Length / 2]} e anche {cibiPreferiti[cibiPreferiti.Length / 2 - 1]}");
