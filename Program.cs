// // Probe.Run();

// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("   Александр   ", 150);
// Hero sergey = new Hero("Сергей", 110);

// alexander.TakeDamage(10);
// alexander.Heal(10);

// Guild guild = new Guild("Гильдия героев");
// guild.AddHero(yaroslav);
// guild.AddHero(anastasia);
// guild.AddHero(artem);
// guild.AddHero(alexander);
// guild.AddHero(sergey);

// List<Hero> members = guild.GetMembers();

// Console.WriteLine($">>> {guild.Name}: перекличка <<<");
// Console.WriteLine($"Участников: {guild.MemberCount}");

// if (members.Count > 0) {
//     Console.WriteLine($"Первый: {members[0].Name}");
//     Console.WriteLine($"Последний: {members[members.Count - 1].Name}");
// }

// Console.WriteLine();
// foreach (Hero hero in members) {
//     Console.WriteLine(hero.GetInfo());
//     Console.WriteLine();
// }

// Hero? found = guild.FindHeroByName(" аРтЁм ");
// if (found != null) {
//     Console.WriteLine($"Найден по запросу « аРтЁм »: {found.Name}");
// } else {
//     Console.WriteLine("По запросу « аРтЁм » никого нет.");
// }

// Console.WriteLine($"Повтор Александра принят: {guild.AddHero(alexander)}");
// Console.WriteLine($"Удалён отсутствующий: {guild.RemoveHero("Борис")}");
// Console.WriteLine($"Участников после проверок: {guild.MemberCount}");

// Console.WriteLine($"Могут нести тяжёлые ящики (здоровье от 120): {guild.CountHealthy(120)}");

// Hero? strongest = guild.FindStrongest();
// if (strongest != null) {
//     Console.WriteLine($"Самый здоровый: {strongest.Name} ({strongest.Health})");
// }

class Program
{
    static void Main()
    {
        GameCatalog catalog = new GameCatalog("Личный проект: Каталог Игр");
        Console.WriteLine($"{catalog.Name}\n");

        Game persona = new Game("Persona 3 Reload", "JRPG", 2024, 10.0);
        Game zelda = new Game("The Legend Of Zelda: Breath Of The Wild", "Cool", 2017, 10.0);
        Game brokenGame = new Game("  ", "", 1800, 15.0);

        catalog.AddGame(persona);
        catalog.AddGame(zelda);
        catalog.AddGame(brokenGame);
        catalog.AddGame(new Game("Cyberpunk 2077", "RPG", 2020, 8.5));

        persona.UpdateRating(9.5);

        List<Game> games = catalog.GetGames();

        Console.WriteLine($"Всего игр в каталоге: {catalog.GamesCount}");
        if (games.Count > 0)
        {
            Console.WriteLine($"Первая игра: {games[0].Title}");
            Console.WriteLine($"Последняя игра: {games[games.Count - 1].Title}");
        }
        Console.WriteLine();

        foreach (Game game in games)
        {
            Console.WriteLine(game.GetInfo());
            Console.WriteLine();
        }

        Game? foundGame = catalog.FindGameByTitle("cyberpunk 2077");
        if (foundGame != null)
        {
            Console.WriteLine($"Найдена игра: {foundGame.Title} (рейтинг: {foundGame.Rating})");
        }
        else
        {
            Console.WriteLine("Игра не найдена.");
        }

        Game? missingGame = catalog.FindGameByTitle("Half-Life 3");
        if (missingGame != null)
        {
            Console.WriteLine($"Найдена игра: {missingGame.Title}");
        }
        else
        {
            Console.WriteLine("По запросу Half-Life 3 ничего не найдено.");
        }

        Game duplicatePersona = new Game("  PERSONA 3 reload ", "RPG", 2024, 9.0);
        Console.WriteLine($"Повтор Persona 3 Reload принят: {catalog.AddGame(duplicatePersona)}");

        Console.WriteLine($"Количество игр до удаления: {catalog.GamesCount}");
        Console.WriteLine($"Удалена игра Без названия: {catalog.RemoveGame("без названия")}");
        Console.WriteLine($"Удалена отсутствующая игра: {catalog.RemoveGame("Ведьмак 3")}");
        Console.WriteLine($"Количество игр после удаления: {catalog.GamesCount}");

        Console.WriteLine($"Игр с отличным рейтингом (от 9.0 и выше): {catalog.CountHighRated(9.0)}");
    }
}