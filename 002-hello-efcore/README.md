# HelloEFCore

## How to run the example?

- Create your local database, and import the `comment.sql` file
- Modify ConnectString at `ApplicationDbContent.OnConfiguring()` method
- Open your favorite terminal at the project root directory and execute `dotnet run`
- Congrats!

## Summary

- Use MySQL database provider
- Create DbContext and configure ConnectString
- Use `using` to manage db connection resource
- Setup DbSet generics for every tables
- Specify table name using annotation attribute if your table name does not follow the convention, so does column name
- Use Linq to query data
- Use foreach to loop comment list and output to the console