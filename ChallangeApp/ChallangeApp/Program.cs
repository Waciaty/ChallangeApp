
using System.ComponentModel.Design;

var name = "Ewa";
var isMale = false;
var age = 33;


if (age < 30 && isMale == false)
{
    Console.WriteLine("Kobieta ponizej lat 30");
}
else if (age == 33 && name == "Ewa" && isMale == false)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && isMale == true)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else if (age == 40 && isMale == true && name == "Kamil")
{
    Console.WriteLine("Kamil, lat 40");
}


