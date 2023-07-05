
DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse("11/6/1998");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));


Console.WriteLine($"Today full format: {today.ToString("d/MM/yy, h:mm tt K")}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");