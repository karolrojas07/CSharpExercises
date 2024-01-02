// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DBConnection db = new SqlConnection("connectionString");
/** DBConnection db = new OracleConnection("connectionString"); */
DBCommand dbCommand = new DBCommand(db, "CommandToExecute");
dbCommand.Execute();
public abstract class DBConnection
{
    private readonly string connectionString;
    private readonly TimeSpan timeout;

    public DBConnection(string connection)
    {
        ArgumentNullException.ThrowIfNull(connection);
        this.connectionString = connection;
        this.timeout = TimeSpan.FromSeconds(1);
    }

    public abstract void Open();

    public abstract void Close();
}

public class SqlConnection : DBConnection
{
    public SqlConnection(string connection) : base(connection)
    {
    }

    public override void Close()
    {
        Console.WriteLine("Close SQL Connection");
    }

    public override void Open()
    {
        Console.WriteLine("Open SQL Connection");
    }
}

public class OracleConnection : DBConnection
{
    public OracleConnection(string connection) : base(connection)
    {
    }

    public override void Close()
    {
        Console.WriteLine("Close Oracle Connection ");
    }

    public override void Open()
    {
        Console.WriteLine("Open Oracle Connection");
    }
}

public class DBCommand
{
    private readonly DBConnection connection;
    private readonly string command;
    public DBCommand(DBConnection db, string commannd)
    {
        ArgumentNullException.ThrowIfNull(db);
        connection = db;
        this.command = commannd;
    }

    public void Execute()
    {
        this.connection.Open();
        Console.WriteLine($"Run: {command}");
        this.connection.Close();
    }
}