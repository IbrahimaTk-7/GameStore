using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games =
[

    new()
        {
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            RealeaseDate = new DateOnly(1999, 7, 15)
        },

    new()
        {
            Id = 2,
            Name = "Final Fantasy XIV",
            Genre = "Roleplaying",
            Price = 59.99M,
            RealeaseDate = new DateOnly(2010, 9, 30)
        },

    new()
        {
            Id = 3,
            Name = "Fifa 23",
            Genre = "Sport",
            Price = 69.99M,
            RealeaseDate = new DateOnly(2022, 9, 27)
        }
];

    public GameSummary[] GetGames() => [.. games];
}
