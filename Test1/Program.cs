using System.Linq.Expressions;
using Test1.DBContext;
using Test1.Model;

using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    АluminumAlloy alloy1 = new АluminumAlloy { Id = Guid.NewGuid(),Name = "6073"};
    АluminumAlloy alloy2 = new АluminumAlloy { Id = Guid.NewGuid(), Name = "6077" };
    db.АluminumAlloys.AddRange(new List<АluminumAlloy> { alloy1, alloy2 });
    db.SaveChanges();


    DictAlloy dict1 = new DictAlloy { AluminumId = alloy1.Id, Type = "bar" };
    DictAlloy dict2 = new DictAlloy { AluminumId = alloy2.Id, Type = "SheetMetal" };
    db.Dictionaries.AddRange(new List<DictAlloy>{ dict1 , dict2});
    db.SaveChanges();

    Console.WriteLine("Сохранен");
    foreach (var alloy in db.АluminumAlloys.ToList())
    {
        Console.WriteLine($"Id:{alloy.Id} Name:{alloy.Name} Type: {alloy.Dict.Type}");
    }
    Console.ReadLine();
}
