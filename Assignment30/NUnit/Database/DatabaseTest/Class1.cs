using NUnit.Framework;
using Database;

namespace DatabaseTest
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection _dbConnection;

        [SetUp]
        public void SetUp()
        {
            _dbConnection = new DatabaseConnection();
            _dbConnection.Connect();
        }

        [TearDown]
        public void TearDown()
        {
            _dbConnection.Disconnect();
        }

        [Test]
        public void Connect_WhenCalled_ShouldSetIsConnectedToTrue()
        {
            Assert.That(_dbConnection.IsConnected, Is.True);
        }

        [Test]
        public void Disconnect_WhenCalled_ShouldSetIsConnectedToFalse()
        {
            _dbConnection.Disconnect();
            Assert.That(_dbConnection.IsConnected, Is.False);
        }
    }
}
