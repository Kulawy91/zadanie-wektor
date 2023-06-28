Wektor v1 = new (5, 6, 7);
Wektor v2 = new (4, 5, 6);
double skalar = 2.5;

Wektor sumaWektorów = Wektor.Suma(v1,v2);
Console.WriteLine($"Suma wektorów:  {sumaWektorów}");

double iloczynSkalarny = Wektor.IloczynSkalarny(v1, v2);
Console.WriteLine("Iloczyn skalarny: " + iloczynSkalarny);

Wektor różnicaWektorów = v1 - v2;
Console.WriteLine("Różnica wektorów: " + string.Join(", ", różnicaWektorów));

Wektor iloczynWektoraISkalar = sumaWektorów * skalar;
Console.WriteLine($"Iloraz wektora i skalar: {iloczynWektoraISkalar}");

Wektor ilorazWektoraISkalar = sumaWektorów / skalar;
Console.WriteLine($"Iloraz wektora i skalar: { ilorazWektoraISkalar}");
