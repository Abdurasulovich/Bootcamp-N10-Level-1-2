
var parentPath = "C:\\Users\\99891\\OneDrive\\Ishchi stol";

Logocas logocas = new Logocas();
logocas.CreateDrs(parentPath, 0);
public class Logocas
{
    public string CreateDrs(string path, int n)
    {
        if (n > 4)
            return "";

        DirectoryInfo drs = new DirectoryInfo(path);

        var dr1 = drs.CreateSubdirectory("test1");
        CreateDrs(dr1.FullName, n + 1);
        var dr2 = drs.CreateSubdirectory("test2");
        CreateDrs(dr2.FullName, n + 1);
        var dr3 = drs.CreateSubdirectory("test3");
        CreateDrs(dr3.FullName, n + 1);

        return "";
    }

}
