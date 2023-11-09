using System.Text;

string sPath = @"/Users/corbianreiser/Documents/Studium Nak/Praxis der Softwareentwicklung/C#-Coding/Kapitel 5 - Arrays/K05_05_TextLesen/EProg_Steven_Jobs.txt";
StreamReader streamReader = new StreamReader(sPath, Encoding.Latin1);

int z;
char c;
char[] cTEmp = new char[5000];
int index = 0;

do
{
    z = streamReader.Read();                // read at leas tone char from txt file
    if (z == 10 || z == 13) continue;       // ignore line end
    if (z < 0 || z == 0) continue;
    c = (char) z;                           // type cast z into char
    cTEmp[index] = c;                       // save character in char array
    index++;                                // increment index
    
} while (z > 0);

char[] cInput = new char[index];

Array.Copy(cTEmp, cInput, index);
Array.Clear(cTEmp, 0, index);

// Finde Words in cInput
string[] sArrayWords = new string[100];
string sWord = string.Empty;
int numWords = 0;
foreach (char ch in cInput)
{
    if (ch == ' ' || ch == '.')
    {
        sArrayWords[numWords] = sWord;
        sWord = String.Empty;
        numWords++;
    }
    else
    {
        if ( ch == '.' || ch == '-' || ch == '?' || ch == '!' || ch == ',') continue;
        sWord += ch;    
    }
    
}

string[] sArraySentence = new string[5];
string sSentence = string.Empty;
int numSentence = 0;
foreach (char ch in cInput)
{
    if (ch == '.')
    {
        sArraySentence[numSentence] = sSentence.Trim();
        sSentence = String.Empty;
        numSentence++;
    }
    else
    {
        sSentence += ch;    
    }
    
}

Console.ReadKey();