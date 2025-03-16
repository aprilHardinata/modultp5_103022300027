// See https://aka.ms/new-console-template for more information
class HaloGeneric
{
    public void sapaUser(string x)
    {
        Console.WriteLine("halo user "+ x);
    }
}

class program
{
    static void Main()
    {
        HaloGeneric generic = new HaloGeneric();

        string nama = Console.ReadLine();
        generic.sapaUser(nama);
    }
}