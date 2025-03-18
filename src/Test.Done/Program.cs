using Done.Core.services;
using Done.Core.utils;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddScoped<IFizzBuzzService, FizzBuzzService>();
services.AddScoped<IFizzBuzzUtil, FizzBuzzUtil>();

var serviceProvider = services.BuildServiceProvider();

var choice = string.Empty;
while (string.IsNullOrEmpty(choice) || (choice != "1" && choice != "2"))
{
    Console.WriteLine("Please select an output type:");
    Console.WriteLine("- 1 - for console");
    Console.WriteLine("- 2 - for file");

    choice = Console.ReadLine();
}

var fizzBuzzService = serviceProvider.GetService<IFizzBuzzService>();

if(fizzBuzzService != null)
    switch (choice)
    {
        case "1":
            fizzBuzzService.DisplayInConsoleFizzBuzz();
            break;
        case "2":
            fizzBuzzService.DisplayInFileFizzBuzz();
            break;
        default:
            fizzBuzzService.DisplayInConsoleFizzBuzz();
            break;
    }
return -1;
