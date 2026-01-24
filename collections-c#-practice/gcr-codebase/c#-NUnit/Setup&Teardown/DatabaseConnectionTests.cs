using NUnit.Framework;

[TestFixture]
public class DatabaseConnectionTests
{
    DatabaseConnection db;

    [SetUp]
    public void ConnectDB()
    {
        db = new DatabaseConnection();
        db.Connect();
    }

    [TearDown]
    public void DisconnectDB()
    {
        db.Disconnect();
    }

    [Test]
    public void Database_IsConnected()
    {
        Assert.IsTrue(db.IsConnected);
    }
}
