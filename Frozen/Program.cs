List<Frozen> myThings = new List<Frozen>(); //kui on loodud uus film, siis salvestatakse see siia listi

string[] data = GetDataFromMyFile();
// et kuvada andmeid massivist
//ReadDataFromArray(data);

// et andmed lahti rebida
foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
    Frozen newThing = new Frozen(tempArray[0], tempArray[1]);
    myThings.Add(newThing);
}

foreach (Frozen frozen in myThings)
{
    Console.WriteLine($"Frozen character {frozen.Character} has {frozen.Thing}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"/Users/reti/projects/data/frozen.txt"; //failil peab olema ka laiend

    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Frozen
{
    string character; //field - klassi väljad
    string thing;

    public string Character //getter
    {
        get { return character; }
    }

    public string Thing //getter
    {
        get { return thing; }
    }

    public Frozen(string _character, string _thing)
    {
        character = _character;
        thing = _thing;

    }
}



