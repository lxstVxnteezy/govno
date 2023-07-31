using System.Linq.Expressions;
using Test1;

using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    ChemicalComposition composition1 = new ChemicalComposition { ChemicalComposition_Name = "al16,mg0,1,si01", ChemicalComposition_Id = Guid.NewGuid() };
    db.Compositions.Add(composition1);

    AluminiumAlloy alloy1 = new AluminiumAlloy { Name = "6565", ChemicalComposition = composition1, Id = Guid.NewGuid() };
    db.AluminiumAlloys.Add(alloy1);

    MaterialExecution execution1 = new MaterialExecution{MaterialExecutionId = Guid.NewGuid(), Type = "rod" };
    MaterialExecution execution2 = new MaterialExecution { MaterialExecutionId = Guid.NewGuid(), Type = "sheet metal" };
    db.MaterialExecutions.AddRange(execution1, execution2);
   
    alloy1.MaterialExecutions.Add(execution1);
    alloy1.MaterialExecutions.Add(execution2);

    db.SaveChanges();

    Console.WriteLine("Сохранен");
    foreach (var alloy in db.AluminiumAlloys.ToList())
    {
        Console.WriteLine($"{alloy.Id} {alloy.ChemicalComposition} {alloy.Name}");
    }

    Console.ReadLine();
}
