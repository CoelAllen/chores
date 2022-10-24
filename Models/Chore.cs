using chores.Enums;

namespace chores.Models;

public class Chore
{
  public string Id { get; set; }
  public string Name { get; set; }
  public string Day { get; set; }
  public bool IsComplete { get; set; }
  public ChoresCategory Category { get; set; }





  public Chore(string name, string day, bool isComplete, ChoresCategory category)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Day = day;
    IsComplete = isComplete;
    Category = category;


  }
}
