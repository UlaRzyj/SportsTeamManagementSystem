namespace SportsTeamManagementSystem;

public interface PlayerType
{
    void AddPlayer();
}

public class Lider : PlayerType
{
    public static List<Player> Liderzy = new List<Player>();
    public void AddPlayer()
    {
        Console.WriteLine("Podaj imie zawodnika: ");
        var name = Console.ReadLine();
        var player = Team.Players.FirstOrDefault(x => x.Name == name);
        if (player != null)
        {
            Liderzy.Add(player);
            Console.WriteLine("Zawodnik dodany do liderów");
        }
        else
        {
            Console.WriteLine("Nie ma takiego zawodnika");
        }
    }
}
public class Wsparcie : PlayerType
{
    public static List<Player> Wspierający = new List<Player>();
    public void AddPlayer()
    {
        Console.WriteLine("Podaj imie zawodnika: ");
        var name = Console.ReadLine();
        var player = Team.Players.FirstOrDefault(x => x.Name == name);
        if (player != null)
        {
            Wspierający.Add(player);
            Console.WriteLine("Zawodnik dodany do wsparcia");
        }
        else
        {
            Console.WriteLine("Nie ma takiego zawodnika");
        }
    }
}

public class Obrońca : PlayerType
{
    public static List<Player> Obrońcy = new List<Player>();
    public void AddPlayer()
    {
        Console.WriteLine("Podaj imie zawodnika: ");
        var name = Console.ReadLine();
        var player = Team.Players.FirstOrDefault(x => x.Name == name);
        if (player != null)
        {
            Obrońcy.Add(player);
            Console.WriteLine("Zawodnik dodany do obrońców");
        }
        else
        {
            Console.WriteLine("Nie ma takiego zawodnika");
        }
    }
}
