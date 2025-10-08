using BOOSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSEapp
{
    class AppCommandFactory : CommandFactory
    {

        public AppCommandFactory() { }
 
        public override ICommand MakeCommand(string commandType)
        {
            // You can add more commands specific to your application here
            return base.MakeCommand(commandType);
        }
    }
}
