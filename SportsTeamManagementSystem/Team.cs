namespace SportsTeamManagementSystem;

public class Team
{
    public static List<Player> Players = new List<Player>();
    public string Role;

    public Team(string role)
    {
        Role = role;
    }
    
    public void AddPlayer()
    {
        if (this.Role == "menedżer")
        {
            Console.WriteLine("Podaj imie zawodnika: ");
            var name = Console.ReadLine();
            Console.WriteLine("Podaj pozycje zawodnika: ");
            var position = Console.ReadLine();
            Console.WriteLine("Podaj wynik zawodnika: ");
            var score = int.Parse(Console.ReadLine());
            while (name is not string || position is not string) {
                Console.WriteLine("Niepoprawne dane, spróbuj ponownie");
                Console.WriteLine("Podaj imie zawodnika: ");
                 name = Console.ReadLine();
                Console.WriteLine("Podaj pozycje zawodnika: ");
                 position = Console.ReadLine();
                Console.WriteLine("Podaj wynik zawodnika: ");
                 score = int.Parse(Console.ReadLine());
            }
            var player = new Player(name, position, score);
            Console.WriteLine("Zawodnik dodany");
        }
        else
        {
            Console.WriteLine("Nie masz uprawnień do dodania zawodnika");
        }
    }
    
    public void DeletePlayer()
    {
        if(this.Role == "menedżer")
        {
            Console.WriteLine("Podaj imie zawodnika: ");
            string name = Console.ReadLine();
            var player = Players.FirstOrDefault(x => x.Name == name);
            Players.Remove(player);
        }
        else
        {
            Console.WriteLine("Nie masz uprawnień do usunięcia zawodnika");
        }
    }

    public void UpdatePlayerScore()
    {
        if(this.Role == "menedżer")
        {
            Console.WriteLine("Podaj imie zawodnika, któremu chcesz zmienić wynik: ");
            string name = Console.ReadLine();
            var player = Players.FirstOrDefault(x => x.Name == name);
            Console.WriteLine("Podaj nowy wynik zawodnika: ");
            int score = int.Parse(Console.ReadLine());
            player.Score = score;
        }
        else
        {
            Console.WriteLine("Nie masz uprawnień do zmiany wyniku zawodnika");
        }
    }

    public void CheckStats()
    {
        if(this.Role == "menedżer")
        {
            foreach (var player in Players)
            {
                Console.WriteLine($"Imie: {player.Name}, Pozycja: {player.Position}, Wynik: {player.Score}");
            }
        }
        else
        {
            Console.WriteLine("Nie masz uprawnień do sprawdzenia statystyk");
        }
    }

    public void ScoreAvg()
    {
        if (this.Role == "menedżer")
        {
            var scores = Players.Select(x => x.Score);
            int sum = scores.Aggregate((acc, i) => acc + i);
            double avg = sum / Players.Count;
            Console.WriteLine($"Średnia punktów drużyny: {avg}");
        }
        else
        {
            Console.WriteLine("Nie masz uprawnień do sprawdzenia średniej punktów");
        }
    }

    public void FilterPlayers()
    {
        Console.WriteLine("Filtrujesz po pozycji - 1 czy typie zawodnika - 2: ");
        var choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Podaj pozycje zawodnika: ");
            string position = Console.ReadLine();
            var players = Players.Where(x => x.Position == position);
            if(players.Count() == 0)
            {
                Console.WriteLine("Brak zawodników na tej pozycji");
            }
            else
            {
                foreach (var player in players)
                {
                    Console.WriteLine($"Imie: {player.Name}, Pozycja: {player.Position}, Wynik: {player.Score}");
                }
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Jaki typ zawodników chcesz ozbaczyć? (lider, wsparcie, obrońca): ");
            string playerType = Console.ReadLine();
            if (playerType == "lider")
            {
                foreach (var liderzy in Lider.Liderzy)
                {
                    Console.WriteLine($"Imie: {liderzy.Name}, Pozycja: {liderzy.Position}, Wynik: {liderzy.Score}");
                }
            }
            else if (playerType == "wpsarcie")
            {
                foreach (var wspierający in Wsparcie.Wspierający)
                {
                    Console.WriteLine(
                        $"Imie: {wspierający.Name}, Pozycja: {wspierający.Position}, Wynik: {wspierający.Score}");
                }
            }
            else if (playerType == "obrońca")
            {
                foreach (var obrońcy in Obrońca.Obrońcy)
                {
                    Console.WriteLine($"Imie: {obrońcy.Name}, Pozycja: {obrońcy.Position}, Wynik: {obrońcy.Score}");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawny typ zawodnika");
            }
        }
        else
        {
            Console.WriteLine("Niepoprawny wybór");
        }

    }

    public void OrderByScore()
    {
        if (this.Role == "menedżer")
        {
            var players = Players.OrderByDescending(x => x.Score);
            foreach (var player in players)
            {
                Console.WriteLine($"Imie: {player.Name}, Pozycja: {player.Position}, Wynik: {player.Score}");
            }
        }
        else
        {
            Console.WriteLine("Nie masz uprawnień do sprawdzenia statystyk");
        }
    }

    public void AddPlayerType()
    {
        if (this.Role == "menedżer")
        {
            Console.WriteLine("Jakiego typu zawodnika chcesz dodać? (lider, wsparcie, obrońca): ");
            string playerType = Console.ReadLine();
            if (playerType == "lider")
            {
                var lider = new Lider();
                lider.AddPlayer();
            }
            else if (playerType == "wsparcie")
            {
                var wsparcie = new Wsparcie();
                wsparcie.AddPlayer();
            }
            else if (playerType == "obrońca")
            {
                var obrońca = new Obrońca();
                obrońca.AddPlayer();
            }
            else
            {
                Console.WriteLine("Niepoprawny typ zawodnika");
            }
        }
    }
}