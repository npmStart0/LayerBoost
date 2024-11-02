using System;
using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lboost
{
    public class CreateCommand : Command
    {
        public CreateCommand() : base("create", "create an empty 3-layers project")
        {
            this.SetHandler(() =>
            {
                //here we need write what the command do
            });
        }
        

        
    }
}
