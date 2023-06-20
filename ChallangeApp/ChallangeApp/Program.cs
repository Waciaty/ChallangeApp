using System.IO.Pipes;

int number = 4466;
char[] numberAsChar = number.ToString().ToCharArray();
char[] counter = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int[] result = new int[10];
foreach (char c in numberAsChar)
{
    for (int i = 0;i < counter.Length;i++)
    {
        if (counter[1] == c)
        {
            result[i] += 1;
        }

    }
}
for (int i = 0; i< counter.Length;i++)
{
    Console.WriteLine(counter[i] + "  ->  " + result[i]);
}