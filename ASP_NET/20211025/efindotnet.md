## Step 1:

```
Install-Package Microsoft.EntityFrameworkCore.SqlServer v3.1.1
Install-Package Microsoft.EntityFrameworkCore.Tools v3.1.1
Install-Package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore v3.1.1
```

## Step 2

Add connection string for SQLServer to appsettings.json 

[docs](https://www.microsoft.com/en-us/sql-server/developer-get-started/csharp/win/step/2.html)

Build connection string

```
Install-Package System.Data.SqlClient v4.8.3
```

```C#
try
{
    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
    builder.DataSource = "localhost";
    builder.InitialCatalog = "contosouniversity";
    builder.IntegratedSecurity = true;

    var str = builder.ConnectionString;
    Console.WriteLine(str);

    using(SqlConnection connection = new SqlConnection(str))
    {
        connection.Open();

        Console.WriteLine(connection.Database);
        Console.WriteLine("Done.");
    }
}
catch (SqlException e)
{
    Console.WriteLine(e);
}
Console.WriteLine("Finished");
```

## Step 3

Add 
