using BOOSE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOSEapp
{
    public class CommandFactory : ICommandFactory
    {
        public virtual ICommand MakeCommand(string commandType)
        {
            commandType = commandType.ToLower().Trim();
            return commandType switch
            {
                "moveto" => new MoveTo(),
                "drawto" => new DrawTo(),
                "circle" => new Circle(),
                "rect" => new Rect(),
                "pen" => new PenColour(),
                "eval" => new Evaluation(),
                "if" => new If(),
                "int" => new Int(),
                "while" => new While(),
                _ => throw new ArgumentException($"Command '{commandType}' is not recognized."),
            };
            throw new NotImplementedException();

        }
    }
}
