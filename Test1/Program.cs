using System.Linq.Expressions;
using Test1.DBContext;
using Test1.Model;

using (ApplicationContext db = new ApplicationContext())
{
    DictionaryType dict1 = new DictionaryType { Type = "SheetMetal",Id = Guid.NewGuid(),Thickness = "10mm"};

    АluminumAlloy alloy1 = new АluminumAlloy { Name = "6061",Id = Guid.NewGuid(), DictionaryTypeId = dict1.Id};

    DictionaryType dict2 = new DictionaryType { Type = "Bar", Id = Guid.NewGuid(),Diameter = "10mm"};

    АluminumAlloy alloy2 = new АluminumAlloy { Name = "6061", Id = Guid.NewGuid(), DictionaryTypeId = dict2.Id };


    db.АluminumAlloys.Add(alloy1);
    db.DictionariesTypes.Add(dict1);

    db.АluminumAlloys.Add(alloy2);
    db.DictionariesTypes.Add(dict2);
    

    db.SaveChanges();
    
    Console.WriteLine("Все ок");

}
