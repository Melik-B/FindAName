//find a name

//ALGORITHM

//1.1 Start.
//1.2 The user is prompted for a name.
//1.3 The name entered by the user is searched in the name list.
//1.4 If the name entered by the user is in the list, the name found is printed on the screen.


//isim bulma

//ALGORİTMA

//1.1 Başla.
//1.2 Kullanıcıdan bir isim istenir.
//1.3 Kullanıcı tarafından girilen isim isim listesinde aranır.
//1.4 Eğer kullanıcının girdiği isim listede varsa ekrana isim bulundu yazdırılır.



string[] names = new string[8]
            {
                "Post Malone",
                "21 Savage",
                "The Weekend",
                "Ufo 361",
                "6ix9ine",
                "Pop Smoke",
                "Drake",
                "Travis Scott"
            };

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.Write("Name: ");
string login = Console.ReadLine();

bool found = false;

foreach (string name in names)
{
    if (name.Trim() == login.Trim())
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(login + " found.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(login + "  not found.");
    Console.ResetColor();
}

Console.WriteLine();

#region Another Method
//foreach (string name in names)
//{
//    if (name.ToUpper().Contains(login.ToUpper()))
//    {
//        found = true;
//        break;
//    }
//}
//if (found)
//{
//    Console.WriteLine(login + " found.");
//}
//else
//{
//    Console.WriteLine(login + "  not found.");
//}
#endregion

Console.ReadLine();