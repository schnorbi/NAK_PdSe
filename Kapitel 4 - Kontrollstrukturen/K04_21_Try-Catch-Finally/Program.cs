int i = 1;
int k = 0;

int iErg;

try
{
    iErg = i / k;
}
catch (DivideByZeroException divideByZeroException)
{
    string strError = divideByZeroException.Message;

}
catch (FormatException formatException)
{
    return;
}
catch (Exception e)
{
    string strError = e.Message;
    Console.WriteLine("Exception in: " + strError);
}
finally
{
    // Todo...
}
Console.ReadKey();