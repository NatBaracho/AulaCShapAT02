using ConversorTemperatura.App;

// var conversor = new ConversorTemperatura() - Metodo errado 

var conversor = new ConversorTemperatura.App.ConversorTemperatura();
Console.WriteLine("Temperatura em Celsius: ");

double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Fahrenheit: {conversor.ParaFahrenheit(c):F1}");

