// if ipAddress consits of 4 numbers
// and
// if each ipAddress number has no leading zeros
// and
// if each ipAddress number is in range 0 - 255

// then ipAddress is valid

// esle ipAddress is invalid

string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeros = false;
bool validRange = false;


foreach(string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeros && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
        Console.WriteLine($"{ip} is an invalid IPv4 address");

}

void ValidateRange()
{
    //string[] address = ipv4Input.Split(".", StringSplitOptions.RemoveEmptyEntries);

    foreach(string number in address)
    {
        int vlaue = int.Parse(number);
        if(vlaue < 0 || vlaue > 255)
        {
            validRange = false;
            return;
        }
    }

    validRange = true;

}

void ValidateZeroes()
{
    //string[] address = ipv4Input.Split(".");

    foreach(string number in address)
    {
        if(number.Length > 1 && number.StartsWith("0"))
        {
            validZeros = false;
            return;
        }
    }

    validZeros = true;

}

void ValidateLength()
{
    //string[] address = ipv4Input.Split(".");
    validLength = address.Length == 4;
}