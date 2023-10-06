//Zadání
//Vytvoř pole typu int s těmito hodnotami {3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4,-2}. Pro kontrolu si obsah pole vypiš.

//Vyhledej záporná čísla a změň je na kladné číslo, zároveň vyhledej nuly a ke každé přičti hodnotu jejího indexu. Výsledné pole si vypiš.

//Vyhledej největší číslo v poli a vypiš ho.

//Seřaď prvky v poli od nejmenšího po největší. Můžeš například využít toho, že už umíš najít největší číslo v poli. Prosím, nepoužívej už hotovou funkci na sortování, jde o to, aby sis takovou funkci zkusila napsat sama.

int[] poleCisel = {3, -4, 0, 21, 3, 16, 7, 0, 1, 3, 4,-2};

//výpis obsahu pole
Console.WriteLine("Výpis startovního obsahu pole: ");
for (int i = 0; i < poleCisel.Length; i++)
{
    Console.Write(poleCisel[i] + " ");
}
Console.WriteLine();


// změna záporných čísel na kladná, k nule přičten index
for (int i = 0; i < poleCisel.Length; i++)
{
    if (poleCisel[i] < 0)
    {
        poleCisel[i] *= -1;
    }
    else if (poleCisel[i] == 0)
    {
        poleCisel[i] += i;
    }
}
// výpis změněného pole
Console.WriteLine("Výpis změněného obsahu pole: ");
for (int i = 0; i < poleCisel.Length; i++)
{
    Console.Write(poleCisel[i] + " ");
}
Console.WriteLine();

// vyhledání největšího čísla v poli
int nejvyssiCislo = poleCisel[0];
for (int i = 0; i < poleCisel.Length; i++)
{
    if (poleCisel[i] > nejvyssiCislo)
    {
        nejvyssiCislo = poleCisel[i];
    }
}
Console.WriteLine("Nejvyšší číslo z pole je {0}", nejvyssiCislo);


// seřazení prvků v poli od nejmenšího po největší - seřazuji teda již změněné pole, nevadí?
int[] serazenePole = new int[poleCisel.Length];
for (int i = 0; i < poleCisel.Length; i++)
{
    int nejvyssiCisloSerazeni = poleCisel[0];
    int poziceNejvyssihoCisla = 0;

    for (int j = 0; j < poleCisel.Length; j++)
    {
        if (poleCisel[j] > nejvyssiCisloSerazeni)
        {
            nejvyssiCisloSerazeni = poleCisel[j];
            poziceNejvyssihoCisla = j;

        }
    }
    serazenePole[serazenePole.Length - (i + 1)] = nejvyssiCisloSerazeni;
    poleCisel[poziceNejvyssihoCisla] = int.MinValue;

}
poleCisel = serazenePole;
Console.WriteLine("Výpis seřazeného obsahu pole: ");
for (int i = 0; i < poleCisel.Length; i++)
{
    Console.Write(poleCisel[i] + " ");
}


Console.ReadLine();