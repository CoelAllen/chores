using chores.Enums;

namespace chores.Data;
public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
    new Chore("Dishes", "Tuesday", false, ChoresCategory.Cleaning),
    new Chore("Feed Dog", "Everyday", false, ChoresCategory.PetCare),
    new Chore("Get Groceries", "Wednesday", false, ChoresCategory.Shopping),
    new Chore("Sort Closet", "Monday", true, ChoresCategory.Organizing)
  };
}