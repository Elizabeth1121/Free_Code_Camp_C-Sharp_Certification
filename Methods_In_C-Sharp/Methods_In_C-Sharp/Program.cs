string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string internalDomain = "contoso.com";

string firstName = string.Empty;
string lastName = string.Empty;

DisplayEmail();
DisplayEmail(externalDomain);

void DisplayEmail(string domain = "contoso.com")
{
    if(domain == "contoso.com")
    {
        for (int i = 0; i < corporate.GetLength(0); i++) 
        {
            // display external email addresses
            firstName = corporate[i, 0].ToLower();
            lastName = corporate[i, 1].ToLower();

            Console.WriteLine($"{firstName[0]}{firstName[1]}{lastName}@{internalDomain}");
        }
    }
    else if (domain == "hayworth.com")
    {
        for (int i = 0; i < external.GetLength(0); i++) 
        {
            // display external email addresses
            firstName = external[i, 0].ToLower();
            lastName = external[i, 1].ToLower();

            Console.WriteLine($"{firstName[0]}{firstName[1]}{lastName}@{externalDomain}");
        }
    }
}