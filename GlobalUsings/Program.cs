
//using System.Text.Json;

string[] names = { "Mutebi", "Fred", "Jonah", "Salli" };
string jsonnames = JsonSerializer.Serialize(names);
Console.WriteLine(jsonnames);
