
public class DeveloperData
{
    public DeveloperData(){}
    public DeveloperData(string firstName, string lastName, int id, bool pluralsightAccess) 
    {
        FirstName = firstName; 
        LastName = lastName; 
        ID = id;
        PluralsightAccess = pluralsightAccess;
    }
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool PluralsightAccess { get; set; }
}
