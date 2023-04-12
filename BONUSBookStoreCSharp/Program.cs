//VARIABLES DECLARATION
Console.Write("Inserisci il titolo del libro:");
string Title = Console.ReadLine();

Console.Write("Inserisci il nome dell'autore:");
string Author = Console.ReadLine();

Console.Write("Inserisci il codice ISBN:");
string CodeISBNString = Console.ReadLine();
long CodeISBN = long.Parse(CodeISBNString);

Console.Write("Inserisci il numero di pagine:");
string NumberOfPagesString = Console.ReadLine();
uint NumberOfPages = uint.Parse(NumberOfPagesString);

Console.Write("Inserisci il peso del libro (kg):");
string BookWeightString = Console.ReadLine();
float BookWeight = float.Parse(BookWeightString); //kilograms

Console.Write("Inserisci la larghezza del libro (cm):");
string BookWidthString = Console.ReadLine();
uint BookWidth = uint.Parse(BookWidthString); //centimeters

Console.Write("Inserisci l'altezza del libro (cm):");
string BookHeightString = Console.ReadLine();
uint BookHeight = uint.Parse(BookHeightString); //centimeter

Console.Write("Inserisci la profondità del libro (cm):");
string BookDepthString = Console.ReadLine();
uint BookDepth = uint.Parse(BookDepthString); //centimeter

Console.Write("Inserisci la valutazione media del libro:");
string BookRatingString= Console.ReadLine();
float BookRating = float.Parse(BookRatingString);

Console.Write("Inserisci il numero di recensioni:");
string NumberOfReviewsString = Console.ReadLine();
uint NumberOfReviews = uint.Parse(NumberOfReviewsString);

//Console.Write("Inserisci il nome dell'autore:");
bool IsKindleAvailable = true;

//Console.Write("Inserisci il nome dell'autore:");
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

