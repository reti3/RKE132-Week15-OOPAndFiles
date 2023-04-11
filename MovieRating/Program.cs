List<Movie> myMovies = new List<Movie>(); //kui on loodud uus film, siis salvestatakse see siia listi

string[] data = GetDateFromMyFile();
// et kuvada andmeid massivist
//ReadDataFromArray(data);

// et andmed lahti rebida
foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[1]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} has rating as {movie.Rating} stars.");
}



static string[] GetDateFromMyFile()
{
    string filePath = @"/Users/reti/projects/data/movies.txt"; //failil peab olema ka laiend

    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string title; //field - klassi väljad
    string rating;

    public string Title //getter
    {
        get { return title; }
    }

    public string Rating //getter
    {
        get { return rating; }
    }

    public Movie(string _title, string _rating)
    {
        title = _title;
        rating = _rating;

    }
}



