using TemperatureConversion;

double celsius = 21.0;
double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);
double kelvin = TemperatureConverter.CelsiusToKelvin(celsius);

Console.WriteLine($"{celsius}°C = {fahrenheit}°F = {kelvin}K");

double fahrenheit2 = 64.0;
double celsius2 = TemperatureConverter.FahrenheitToCelsius(fahrenheit2);
double kelvin2 = TemperatureConverter.FahrenheitToKelvin(fahrenheit2);

Console.WriteLine($"{fahrenheit2}°F = {celsius2}°C = {kelvin2}K");

double kelvin3 = 250.0;
double celsius3 = TemperatureConverter.KelvinToCelsius(kelvin3);
double fahrenheit3 = TemperatureConverter.KelvinToFahrenheit(kelvin3);

Console.WriteLine($"{kelvin3}K = {celsius3}°C = {fahrenheit3}°F");