// See https://aka.ms/new-console-template for more information

class DataGeneric<T>
{
    private T data; 

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}

class HaloGeneric
{
    public void sapaUser(string x)
    {
        Console.WriteLine("halo user "+ x);
    }
}

class Program
{
    static void Main()
    {
        DataGeneric<string> nimData = new DataGeneric<string>("103022300027");

        nimData.PrintData();
      
         HaloGeneric generic = new HaloGeneric();

        string nama = Console.ReadLine();
        generic.sapaUser(nama);
    }
}
