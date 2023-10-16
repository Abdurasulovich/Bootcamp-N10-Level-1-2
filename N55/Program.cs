/*Logical logical = new Logical();
logical.FindFile("D:\\My things", "InstallNavi.exe");
public class Logical
{
    public void FindFile(string parentPath, string fileName)
    {
        if (parentPath == null && parentPath == "")
        {
            Console.WriteLine("File path and file name have to give");
            return;
        }
        

        var directory = new DirectoryInfo(parentPath!);
        var subDirectory = directory.GetDirectories();
        var subFiles = directory.GetFiles();
        foreach(var f in subFiles)
        {
            if (f.Name == fileName)
            {
                Console.WriteLine(f.FullName, ConsoleColor.Green);
                return;
            }
        }
        foreach(var d in subDirectory)
        {
            FindFile(d.FullName, fileName);
        }

    }
}*/

using N55;

//PathExample.Execute();

FolderExample.Execute();