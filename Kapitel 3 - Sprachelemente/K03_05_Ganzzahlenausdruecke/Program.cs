Console.WriteLine("Bitte geben Sie eine Zahl ein: ");

int inputnumber;
int digit;
int pos = 0;

if (int.TryParse(Console.ReadLine(), out inputnumber))
{
    do
    {
        digit = inputnumber % 10;
        inputnumber /= 10;
        pos += 1;
        Console.WriteLine($"postition {pos}: digit = {digit}");
    } while (inputnumber != 0);
}

// a) flase
// b) true
// c) true
// d) true
// e) flase
// f) true
// g) true
// h) false
// i) false