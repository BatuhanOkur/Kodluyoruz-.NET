class Board
{
    List<Card> toDoLine = new List<Card>();
    List<Card> inProgressLine = new List<Card>();
    List<Card> doneLine = new List<Card>();
    List<TeamMember> team = new List<TeamMember>();
    int selection;
    public void Start()
    {
        TeamMember member1 = new TeamMember(3259,"Kaan Bakan");
        TeamMember member2 = new TeamMember(5251,"Anıl Elmastaşı");
        TeamMember member3 = new TeamMember(4212,"Batuhan Okur");

        team.Add(member1);
        team.Add(member2);
        team.Add(member3);
        while(true)
        {
            Console.WriteLine(@"Lütfen yapmak istediğiniz işlemi seçin: 
            (1) Board Listelemek
            (2) Boarda Kart Eklemek
            (3) Boarddan Kart Silmek
            (4) Kart Taşımak
            (5) Çıkış");
            Console.Write("Seçim: ");
            selection = Convert.ToInt32(Console.ReadLine());
            switch(selection)
            {
                case 1:
                    ListLine();
                    break;
                case 2:
                    AddCard();
                    break;
                case 3:
                    DeleteCard();
                    break;
                case 4:
                    TransferCard();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir seçim yapın!");
                    break;
            }
        }
    }

    public void ListLine()
    {
        Console.WriteLine("*******ToDo Listesi************");
        foreach(var card in toDoLine)
        {
            Console.WriteLine(
            @"Başlık: {0}
            İçerik: {1}
            Atanan Kişi: {2}
            Büyüklük: {3}", card.Header, card.Content, card.Member, card.Size);
        }

        Console.WriteLine("*******In Progress Listesi************");
        foreach(var card in inProgressLine)
        {
            Console.WriteLine(
            @"Başlık: {0}
            İçerik: {1}
            Atanan Kişi: {2}
            Büyüklük: {3}", card.Header, card.Content, card.Member, card.Size);
        }

        Console.WriteLine("*******Done Listesi************");
        foreach(var card in doneLine)
        {
            Console.WriteLine(
            @"Başlık: {0}
            İçerik: {1}
            Atanan Kişi: {2}
            Büyüklük: {3}", card.Header, card.Content, card.Member, card.Size);
        }
    }

    public void AddCard()
    {
        Console.WriteLine("Eklemek istediğiniz kartın özelliklerini girin: ");
        Console.WriteLine("Başlık bilgisini girin: ");
        string newHeader = Console.ReadLine().ToLower();
        Console.WriteLine("İçerik bilgisini girin: ");
        string newContent = Console.ReadLine().ToLower();
        Console.WriteLine("Takım üyesinin ID'sini girin: ");
        TeamMember newMember = Assign();
        Console.Write("Lütfen büyüklük girin => XS(1),S(2),M(3),L(4),XL(5) : ");
        Size newCardSize = (Size)Convert.ToInt32(Console.ReadLine());
        Card card = new Card(newHeader, newContent, newMember, newCardSize);
        toDoLine.Add(card);
    }

    public void DeleteCard()
    {
        Console.WriteLine("Silinecek kardın başlığını girin: ");
        string searchString = Console.ReadLine().ToLower();
        foreach(Card card in toDoLine)
        {
            if(searchString.Equals(card.Header))
            {
                toDoLine.Remove(card);
                break;
            }
        }
        foreach(Card card in inProgressLine)
        {
            if(searchString.Equals(card.Header))
            {
                inProgressLine.Remove(card);
                break;
            }
        }
        foreach(Card card in doneLine)
        {
            if(searchString.Equals(card.Header))
            {
                doneLine.Remove(card);
                break;
            }
        }
        Console.WriteLine(@"Aradığınız kart bulunamadı!
        Çıkmak için (1)
        Tekrar denemek için (2) basın.");
        switch(Console.ReadLine())
        {
            case "1":
                break;
            case "2":
                DeleteCard();
                break;
            default:
                Console.WriteLine("Lütfen geçerli bir seçim yapın! (1 veya 2)");
                break;
        }
    }

    public void TransferCard()
    {
        Console.WriteLine("Transfer edilecek kardın başlığını girin: ");
        string searchString = Console.ReadLine().ToLower();
        Card transferCard = new Card();
        foreach (Card card in toDoLine)
            {
                if (searchString.Equals(card.Header))
                {
                    Console.WriteLine("Kart Bilgileri : \n" +
                        "Başlık : {0}\n" +
                        "İçerik : {1}\n" +
                        "Takım Üyesi : {2}\n" +
                        "Boyut : {3}\n" +
                        "Liste : TODO Listesi", card.Header, card.Content, card.Member.FullName, card.Size);
                        transferCard = card;
                }
            }
            foreach (Card card in inProgressLine)
            {
                if (searchString.Equals(card.Header))
                {
                    Console.WriteLine("Kart Bilgileri : \n" +
                        "Başlık : {0}\n" +
                        "İçerik : {1}\n" +
                        "Takım Üyesi : {2}\n" +
                        "Boyut : {3}\n" +
                        "Liste : In Progress Listesi", card.Header, card.Content, card.Member.FullName, card.Size);
                        transferCard = card;
                }
            }
            foreach (Card card in doneLine)
            {
                if (searchString.Equals(card))
                {
                    Console.WriteLine("Kart Bilgileri : \n" +
                        "Başlık : {0}\n" +
                        "İçerik : {1}\n" +
                        "Takım Üyesi : {2}\n" +
                        "Boyut : {3}\n" +
                        "Liste : Done Listesi", card.Header, card.Content, card.Member.FullName, card.Size);
                        transferCard = card;
                }
                
            }

            int select = Convert.ToInt32(Console.ReadLine());
            switch(select)
            {
                case 1:
                    toDoLine.Remove(transferCard);
                    toDoLine.Add(transferCard);
                    break;
                case 2:
                    toDoLine.Remove(transferCard);
                    inProgressLine.Add(transferCard);
                    break;
                case 3:
                    toDoLine.Remove(transferCard);
                    doneLine.Add(transferCard);
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir seçim yapın!");
                    break;
            }
    }

    public TeamMember Assign()
    {
        Console.WriteLine("Takım Üyeleri : \n" +
            "************************************");
        foreach (var person in team)
        {
            Console.WriteLine("ID : {0}\n" +
                "İsim Soyisim : {1}", person.Id, person.FullName);
        }
        Console.Write("Lütfen listedeki bir üyenin ID'sini girin: ");
        int value = Convert.ToInt32(Console.ReadLine());
        return team.Where(person => person.Id == value).FirstOrDefault();
    }


}