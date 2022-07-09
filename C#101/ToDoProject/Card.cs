class Card
{
    private string header;
    private string content;
    TeamMember member;
    Size size;

    public Card(string header, string content, TeamMember member, Size size)
    {
        this.header = header;
        this.content = content;
        this.member = member;
        this.size = size;
    }
    
    public Card(){}
    
    public string Header { get => header; set => header = value; }
    public string Content { get => content; set => content = value; }
    internal TeamMember Member { get => member; set => member = value; }
    internal Size Size { get => size; set => size = value; }
}