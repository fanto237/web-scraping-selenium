
using Sandbox;

var driver = new Driver();
try
{
    var file = new StreamReader(@"order.txt");
    //Read the first line of text
    var line = file.ReadLine();
    var url = line;
    while (line is not null)
    {
        if(!string.IsNullOrWhiteSpace(line))
            Console.WriteLine(line);
        line = file.ReadLine();
    }
    
    file.Close();
    driver.OpenBrowser(url);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadKey();


