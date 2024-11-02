using lboost;
using System.CommandLine;
using System.CommandLine.Invocation;

var rootCommand = new RootCommand("")
{
};

// Add a subcommand
var createCommand = new CreateCommand
{

};

rootCommand.AddCommand(createCommand);

await rootCommand.InvokeAsync(args);
