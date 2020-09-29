using System.Collections.Generic;
namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Description { get; set; }

    public Contact Contact { get; set; }



    private static List<JobOpening> _instances = new List<JobOpening> { };

    public JobOpening(string title, string description, Contact contact)
    {
      Title = title;
      Description = description;
      Contact = contact;
      _instances.Add(this);

    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }


    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}