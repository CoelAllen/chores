using chores.Data;

namespace chores.Services;
public class ChoresService
{
  private readonly FakeDb _db;
  public List<Chore> GetChores()
  {
    return _db.Chores;
  }
  public Chore GetChore(string id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null)
    {
      throw new Exception("Invalid Id");
    }
    return chore;
  }
  public Chore AddChore(Chore choreData)
  {
    _db.Chores.Add(choreData);
    return choreData;
  }
  public Chore EditChore(Chore choreData)
  {
    Chore chore = this.GetChore(choreData.Id);
    if (chore == null)
    {
      throw new Exception("Invalid Id");
    }
    chore.Name = choreData.Name;
    chore.IsComplete = choreData.IsComplete;
    chore.Day = choreData.Day;
    chore.Category = choreData.Category;

    return chore;
  }

  internal Chore DeleteChore(string id)
  {
    Chore chore = this.GetChore(id);
    _db.Chores.Remove(chore);
    return chore;

  }







  public ChoresService(FakeDb db)
  {
    _db = db;
  }

}