public class Rehber
{
    private string fullName;
    private int no;

    public Rehber(string fullName, int no)
    {
        this.fullName = fullName;
        this.no = no;
    }

    public string FullName { get => fullName; set => fullName = value; }
    public int No { get => no; set => no = value; }
}