using static System.Console;

class Database
{
    public Database(string dbname) { }

    public void Backup()
    {
    }
    public void Remove() => WriteLine("Remove DB");
}

class Program
{
    public static void Main()
    {
        Database db = new Database("product.db");

        db.Backup();    

        db.Remove();
    }
}
