namespace SessionOne.Example_03
{

    [Flags]
    internal enum Premissions :byte
    {
        write,
        read,
        delete,
        execute,
    }
}
