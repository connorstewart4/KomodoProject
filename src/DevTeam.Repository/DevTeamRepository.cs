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
}
