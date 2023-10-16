namespace N55;

public static class FolderExample
{
    public static void Execute()
    {
        var appFolder = Directory.GetCurrentDirectory();

        var folderName = "Resumes";
        var folderAbsolutePath = Path.Combine("D:\\Temp\\Data", folderName);

        //Create 
        Directory.CreateDirectory(folderName);
        Directory.CreateDirectory(folderAbsolutePath);

        //Enumerate

        //Entry - abstract, directory yoki file
        //Directory - papka, folder, fayllarni guruhlab turadigan narsa
        //File - binary yoki text formatdagi ma'lumotlar

        var entries = Directory.EnumerateFileSystemEntries(appFolder);
        var folder = Directory.GetDirectories(appFolder);
        var files = Directory.GetFiles(appFolder);

        //Delete - Empty bo'lmasa exception bo'ladi qachonki recursive true berilmasa

        //Directory.Delete("D:\\My things\\NajotTa'lim\\Bootcamp N10 Lessons\\Bootcamp-N10-Level-1-2\\N55\\bin\\Debug\\net7.0\\Data",
        //          true);

        //Move
        //Directory.Move(@"D:\\Temp\\Data", Path.Combine(appFolder, "Data"));

        //Parent
        Console.WriteLine(Directory.GetParent(appFolder));

        //Drive
        var drives = Directory.GetLogicalDrives();
        Console.WriteLine(drives);
    }
}
