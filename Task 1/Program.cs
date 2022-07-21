// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Task_1.MovieStar;

List<MovieStar> movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(File.ReadAllText("input.txt"));

foreach(MovieStar movieStar in movieStars)
{
    Console.WriteLine(movieStar.ToString());
}
