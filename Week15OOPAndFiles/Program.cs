List<Movie> myMovies = new List<Movie>(); //kui on loodud uus film, siis salvestatakse see siia listi

string[] data = GetDataFromMyFile();
// et kuvada andmeid massivist
//ReadDataFromArray(data);

// et andmed lahti rebida
foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}");
}



static string[] GetDataFromMyFile()
{
    string filePath = @"/Users/reti/projects/data/movies.txt"; //failil peab olema ka laiend

    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string title; //field - klassi väljad
    string year;

    public string Title //getter
    {
        get { return title; }
    }

    public string Year //getter
    {
        get { return year; }
    }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;

    }
}

