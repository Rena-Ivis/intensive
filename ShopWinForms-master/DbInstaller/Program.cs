using System.Configuration;
using System.Data.SqlClient;

namespace DbInstaller
{

    public class Program
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["AdoNetPractice"].ToString();
        private static readonly string MasterConnectionString = ConfigurationManager.ConnectionStrings["Master"].ToString();

        static void Main(string[] args)
        {
            if (!DbExist())
            {
                ExecuteSql(MasterConnectionString, createDBSql);
                //ExecuteSql(MasterConnectionString, createUserSql);
            }
            ExecuteSql(ConnectionString, createTablesSql);
        }

        private static bool DbExist()
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static void ExecuteSql(string connectionString, string sqlCommand)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var command = new SqlCommand(sqlCommand, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        #region Sql

        private static readonly string createDBSql = $@"CREATE DATABASE [AdoNetPractice]";
        private static readonly string createUserSql = $@"
CREATE LOGIN Simbirsoft WITH PASSWORD = 'simbirsoft'
GO
Use AdoNetPractice;
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'Simbirsoft')
BEGIN
    CREATE USER [Simbirsoft] FOR LOGIN [Simbirsoft]
    EXEC sp_addrolemember N'db_owner', N'Simbirsoft'
END;
GO
";

        private static readonly string createTablesSql = $@"
USE AdoNetPractice;
CREATE TABLE dbo.Clients
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL, 
    [Email] NVARCHAR(150) NOT NULL, 
    [Phone] NVARCHAR(150) NOT NULL
);
CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(150) NOT NULL, 
    [Price] DECIMAL(18,2) NOT NULL
);
CREATE TABLE [dbo].[Orders] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [ProductId] INT NOT NULL,
    [ClientId]  INT NOT NULL,
    [Count]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_Orders_ToClients] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Clients] ([Id])
);
";
#endregion
    }
}
