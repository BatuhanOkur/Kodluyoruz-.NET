class TeamMember
{
    private int id;
    private string fullName;

    public int Id { get => id; set => id = value; }
    public string FullName { get => fullName; set => fullName = value; }

    public TeamMember(int id, string fullName)
    {
        this.id = id;
        this.fullName = fullName;
    }
}