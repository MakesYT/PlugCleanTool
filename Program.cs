﻿// See https://aka.ms/new-console-template for more information
//程序运行的当前目录

Console.WriteLine(Directory.GetCurrentDirectory());


DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory() + "//plugins");
if (dir.Exists)
{
    foreach (var file in dir.GetDirectories())
    {
        Console.WriteLine($"插件名称{file.Name}");
        var path = $"{file.FullName}{Path.DirectorySeparatorChar}{file.Name}.deps.json";
        Console.WriteLine(path);
        File.Delete(path);
        File.Delete($"{file.FullName}{Path.DirectorySeparatorChar}{file.Name}.runtimeconfig.json");
        File.Delete($"{file.FullName}{Path.DirectorySeparatorChar}Microsoft.Windows.SDK.NET.dll");
        File.Delete($"{file.FullName}{Path.DirectorySeparatorChar}WinRT.Runtime.dll");
    }

    foreach (var fileInfo in new DirectoryInfo(Directory.GetCurrentDirectory()).GetFiles())
    {
        if (fileInfo.Extension is ".pdb" or ".xml")
        {
            fileInfo.Delete();
        }
       
        
    }
}