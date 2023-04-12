//VARIABLES DECLARATION
Console.Write("Inserisci il titolo del libro:");
string Title = Console.ReadLine();
Console.Write("Inserisci il nome dell'autore:");
string Author = Console.ReadLine();
long CodeISBN = 4234567891;
uint NumberOfPages = 1000;
float BookWeight = 1.2f; //kilograms
uint BookWidth = 25; //centimeters
uint BookHeight = 40; //centimeters
uint BookDepth = 4; //centimeters
float BookRating = 4.5f;
uint NumberOfReviews = 23453;
bool IsKindleAvailable = true;
bool IsFlexibleCoverAvailable = true;

string KindleAvailability = "";

if (IsKindleAvailable)
{
    KindleAvailability = "SI";
}
else
{
    KindleAvailability = "NO";
};

string FlexibleCoverAvailability = "";

if (IsFlexibleCoverAvailable)
{
    FlexibleCoverAvailability = "SI";
}
else
{
    FlexibleCoverAvailability = "NO";
};


//OUTPUT DISPLAY IN CONSOLE
Console.WriteLine("-------- IL LIBRO DI OGGI: " + Title + " di " + Author + " ------------");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + CodeISBN);
Console.WriteLine("Numero delle pagine: " + NumberOfPages + " pagine");
Console.WriteLine("Peso del libro: " + BookWeight + " kg");
Console.WriteLine("Dimensioni del libro: " + BookWidth + " cm x " + BookHeight + " cm x " + BookDepth + " cm");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di recensioni: " + NumberOfReviews + " recensioni");
Console.WriteLine("Valutazione media: " + BookRating + " stelline");
Console.WriteLine("Kindle disponibile: " + KindleAvailability);
Console.WriteLine("Copertina flessibile disponibile: " + FlexibleCoverAvailability);
Console.WriteLine("-----------------------------------------------------------------");

