using System.Text.Json.Serialization;

namespace chores.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChoresCategory
{
  Cleaning,
  Organizing,
  Shopping,
  PetCare

}

