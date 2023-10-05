using EFCore.Linq.ExtensionMethod;

using var context = new AppDbContext();

string nameFilter = "";
string emailFilter = "";

var constomers = context.Customers
    .WhereIf(!string.IsNullOrEmpty(nameFilter), c => c.Name == nameFilter)
    .WhereIf(!string.IsNullOrEmpty(emailFilter), c => c.Email == emailFilter)
    .ToList();

Console.ReadLine();
