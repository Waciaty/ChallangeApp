using System.IO.Pipes;

int czyslo = 4466;
string a = czyslo.ToString();
char[] simw = a.ToCharArray();
string[] tablica = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
int[] znacz = new int[10];
for (int i = 0;i< simw.Length; i++)
{
        for (int g = 0;g < tablica.Length;g++)
    {
                if (int.Parse(tablica[g])  == int.Parse(simw[i].ToString()))
        {  
            znacz[g]++;
        }

    }
}
for (int i = 0; i< tablica.Length;i++)
{
    Console.WriteLine(tablica[i] + "  ->  " + znacz[i]);
}