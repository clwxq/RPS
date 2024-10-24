using RPS;
using Spectre.Console;
Kodik kodik = new Kodik();

gamestart:
string choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Welcome choose game mode")
            .PageSize(10)
            .AddChoices(new[] {
           "Singleplayer","Multiplayer"
            }));
switch (choice)
{
    case "Singleplayer":
        kodik.Single();
        break;

    case "Multiplayer":
        kodik.Multi();
        break;
}
choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Wanna play again")
            .PageSize(10)
            .AddChoices(new[] {
           "ye","nah"
            }));
switch (choice)
{
    case "ye":
        goto gamestart;
        break;
    case "nah":
        Environment.Exit(0);
        break;
}