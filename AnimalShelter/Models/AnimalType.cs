using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class AnimalType
  {
    private static List<AnimalType> _instances = new List<AnimalType> {};
    public string Type {get; set;}
    public int Id {get;set;}
    public List<Animal> Animal {get; set;}
    public AnimalType(string type)
    {
      Type = type;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<AnimalType> GetAll()
    {
      return _instances;
    }
    public static AnimalType find(int searchId)
    {
      return _instances[searchId-1];
    }
    public void AddAnimal(Animal animal)
    {
      Animal.Add(animal);
    }
  }
}