using System.Collections.Generic;
using System;
namespace AnagramApp.Models
{
  public class AnagramGenerator
  {
    private string _description;
    private int _id;
    private static List<AnagramGenerator> _instances = new List<AnagramGenerator> {};

    public AnagramGenerator (string description)
    {
      _description = description;
      _id = _instances.Count + 1;
    }
    public int GetId()
    {
      return _id;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<AnagramGenerator> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static AnagramGenerator Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
