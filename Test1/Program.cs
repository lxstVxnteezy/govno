using System.Linq.Expressions;
using Test1.DBContext;
using Test1.Entities;
using Test1.Model;

using (ApplicationContext db = new ApplicationContext())

{
    Unit percentUnit = new Unit { Id = Guid.NewGuid(), NameOfUnit = "%" };
    Unit millimeterUnit = new Unit { Id = Guid.NewGuid(), NameOfUnit = "MM" };

    DictionaryType dict1 = new DictionaryType { Type = "SheetMetal",Id = Guid.NewGuid(),Thickness = "10",UnitName = millimeterUnit.NameOfUnit};

    АluminumAlloy alloy1 = new АluminumAlloy { Name = "6061",Id = Guid.NewGuid(), DictionaryTypeId = dict1.Id};

    DictionaryType dict2 = new DictionaryType { Type = "Bar", Id = Guid.NewGuid(),Diameter = "10",UnitName = millimeterUnit.NameOfUnit};

    АluminumAlloy alloy2 = new АluminumAlloy { Name = "6061", Id = Guid.NewGuid(), DictionaryTypeId = dict2.Id };

    ChemicalElement Aluminum = new ChemicalElement{Id = Guid.NewGuid(),NameOfElement = "Aluminum"};


    db.Units.Add(percentUnit);
    db.Units.Add(millimeterUnit);

    db.АluminumAlloys.Add(alloy1);
    db.DictionariesTypes.Add(dict1);

    db.АluminumAlloys.Add(alloy2);
    db.DictionariesTypes.Add(dict2);

    alloy1.ChemicalCompositions.Add(new ChemicalComposition{NameOfElement  = Aluminum.NameOfElement , AmountElement = "96", ChemicalElement = Aluminum, Unit  = percentUnit, UnitName = percentUnit.NameOfUnit});
    
    db.SaveChanges();
    
    Console.WriteLine("Все ок");

}
