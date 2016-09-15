public static class Paths
{
    public static DirectoryPath Temp { get; private set; }
    public static DirectoryPath Resources { get; private set; }

    public static void Initialize(ICakeContext context)
    {
        Temp = new DirectoryPath("./temp").MakeAbsolute(context.Environment);
        Resources = new DirectoryPath("./resources").MakeAbsolute(context.Environment);
    }
}

Paths.Initialize(Context);