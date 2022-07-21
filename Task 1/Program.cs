// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Task_1.MovieStar;

var movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(File.ReadAllText("input.txt"));

if(movieStars == null)
{
    throw new ArgumentNullException("No movie stars");
}

foreach(MovieStar movieStar in movieStars)
{
    Console.WriteLine(movieStar.ToString());
}
