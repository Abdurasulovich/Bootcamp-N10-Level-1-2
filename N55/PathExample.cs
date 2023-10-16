using System.Runtime.InteropServices;

namespace N55;

public static class PathExample
{
    public static void Execute()
    {
        //Path turlari

        //absolute - D:\Projects\BNN10-Level-I-2\N55-C\bin\Debug\net7.0\Data\DataStorage\users.json
        // relative - DataStorage\users.json, Data\FilesStorage\23423432-resume.pdf

        //strorage root path - D:\Projects\BNN10-Level-I-2\N55-C\bin\Debug\net7.0\

        //separator - umumiy path ichidagi qismlarni ajratib turadi

        //pathlarni qo'shish

        var appFolderPath = "D:\\My things\\NajotTa'lim\\Bootcamp N10 Lessons\\Bootcamp-N10-Level-1-2\\N55\\bin\\Debug\\net7.0";
        var fileRelativePath = "\\Data\\Resumes\\users.json";
        var fileAbsolutePath = Path.Combine(appFolderPath, fileRelativePath);

        Console.WriteLine(Path.GetRelativePath(appFolderPath, fileAbsolutePath));
        Console.WriteLine(Path.GetFullPath(fileRelativePath));

        var dataDirectory = "Data";
        var dataStorage = "DataStorage";
        var file = "users.json";

        //combine - pathlarni absolute pathni boshiga qo'yib qo'shadi
        //join - pathlarni shunchaki qo'shadi

        var AbsolutePathA = Path.Combine(fileRelativePath, appFolderPath, fileRelativePath, appFolderPath);
        var AbsolutePathB = Path.Join(fileRelativePath, appFolderPath, fileRelativePath, appFolderPath);

        Console.WriteLine();
        Console.WriteLine($"Combine - {AbsolutePathA}");
        Console.WriteLine($"Join - {AbsolutePathB}");

        //Path validation

        //Exist - path ni bor yo'qligini tekshirish
        //Console.WriteLine(Path.Exists(fileRelativePathA));
        //Console.WriteLine(Path.Exists(fileAbsolutePathB));
        //Console.WriteLine(Path.Exists(@"Data\DataStorage\orders.json"));

        // Invalid characters
        var validFileName = "users.json";
        var invalidFileName = "?";

        Console.WriteLine(validFileName.Any(@char => Path.GetInvalidFileNameChars().Contains(@char)));
        Console.WriteLine(invalidFileName.Any(@char => Path.GetInvalidFileNameChars().Contains(@char)));

        //Extension

        var fileNameWithoutExtensionA = "Jasurbek-Hakimov-Resume";
        var fileNameWithoutExtensionB = "Jasurbek-Hakimov..Resume";
        var fileNameWithoutExtensionC = "Jasurbek-Hakimov-Resume.jpeg";
        var fileNameWithoutExtensionD = "D:\\";
        var fileNameWithoutExtensionE = "Jasurbek-Hakimov-Resume.jpg";
        var fileExtention = "pdf";

        Console.WriteLine(Path.ChangeExtension(fileNameWithoutExtensionA, fileExtention));
        Console.WriteLine(Path.ChangeExtension(fileNameWithoutExtensionB, fileExtention));
        Console.WriteLine(Path.ChangeExtension(fileNameWithoutExtensionC, fileExtention));
        Console.WriteLine(Path.ChangeExtension(fileNameWithoutExtensionD, fileExtention));
        Console.WriteLine(Path.ChangeExtension(fileNameWithoutExtensionE, fileExtention));


        Console.WriteLine(Path.HasExtension(fileNameWithoutExtensionA));
        Console.WriteLine(Path.HasExtension(fileNameWithoutExtensionB));
        Console.WriteLine(Path.HasExtension(fileNameWithoutExtensionC));
        Console.WriteLine(Path.HasExtension(fileNameWithoutExtensionD));
        Console.WriteLine(Path.HasExtension(fileNameWithoutExtensionE));

        Console.WriteLine(Path.GetExtension(fileNameWithoutExtensionE));

        //Path.IsPathFullyQualified();

        //File va Folder name

        Console.WriteLine(Path.GetFileName(fileRelativePath));
        Console.WriteLine(Path.GetFileNameWithoutExtension(fileRelativePath));
        Console.WriteLine(Path.GetDirectoryName(fileRelativePath));


        //Temp yoki random name

        Console.WriteLine(Path.GetTempPath());
        Console.WriteLine(Path.GetTempFileName());
        Console.WriteLine(Path.GetRandomFileName());

    }
}
