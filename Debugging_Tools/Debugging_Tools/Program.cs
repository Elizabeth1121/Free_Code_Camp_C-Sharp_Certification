/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

x = ChangeValue(x);

Console.WriteLine(x);

int ChangeValue(int value) 
{
    return value = 10;
}

// SOLUTION: the value was never updated becasue we never assigned the return value of the ChangeValue method to the variable x, and the method was set to void so it didn't return anything.