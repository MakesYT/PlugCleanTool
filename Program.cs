// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine($"插件名称{args[0]}");
File.Delete($"{args[0]}.deps.json");
File.Delete($"{args[0]}.runtimeconfig.json");
File.Delete($"Microsoft.Windows.SDK.NET.dll");
File.Delete($"WinRT.Runtime.dll");