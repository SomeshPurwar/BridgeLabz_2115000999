using System;

public class LegacyAPI
{
    [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("This is the old feature.");
    }

    public void NewFeature()
    {
        Console.WriteLine("This is the new feature.");
    }
}

public class Test2
{
    public static void Print()
    {
        LegacyAPI api = new LegacyAPI();

        // Calling the old method (will show a warning)
        api.OldFeature();

        // Calling the new method
        api.NewFeature();
    }
}
