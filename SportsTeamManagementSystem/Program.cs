// See https://aka.ms/new-console-template for more information

using SportsTeamManagementSystem;

internal class Program
{
    public static void Main(string[] args)
    {
        var team = new Team("menedżer");
        var playerOne = new Player("Jan", "Napastnik", 10);
        var playerTwo = new Player("Kamil", "Obrońca", 8);
        var playerThree = new Player("Piotr", "Pomocnik", 7);
        var playerFour = new Player("Marek", "Napastnik", 9);
        var playerFive = new Player("Krzysztof", "Obrońca", 8);
        var playerSix = new Player("Paweł", "Pomocnik", 7);
        team.CheckStats();
        team.AddPlayer();
        team.DeletePlayer();
        team.CheckStats();
        team.UpdatePlayerScore();
        team.CheckStats();
        team.AddPlayerType();
        team.AddPlayerType();
        team.AddPlayerType();
        team.OrderByScore();
        team.FilterPlayers();
        
        
    }
}