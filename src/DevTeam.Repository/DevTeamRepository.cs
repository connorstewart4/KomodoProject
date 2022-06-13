public class DevTeamRepository
{
    private readonly List<DevTeam> _devTeamDatabase = new List<DevTeam>();
    private int _count = 0;

    public bool AddDevTeamToDatabase(DevTeam devTeam)
    {
        if(devTeam != null)
        {
            _count++;
            DevTeam.ID = _count;
            _devTeamDatabase.Add(devTeam);
        }
    }

    public List<DevTeam> GetAllTeams()
    {
        return _devTeamDatabase;
    }

    public DevTeam GetTeamByID(int id)
    {
        foreach(DevTeam t in _devTeamDatabase)
        {
            if (t.ID == id)
            {
                return t;
            }
        }
        return null;
    }
}
