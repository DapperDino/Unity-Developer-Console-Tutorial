using UnityEngine;

namespace DapperDino.UDCT.Utilities.DeveloperConsole.Commands
{
    [CreateAssetMenu(fileName = "New Gravity Command", menuName = "Utilities/DeveloperConsole/Commands/Gravity Command")]
    public class GravityCommand : ConsoleCommand
    {
        public override bool Process(string[] args)
        {
            if (args.Length != 1) { return false; }

            if (!float.TryParse(args[0], out float value))
            {
                return false;
            }

            Physics.gravity = new Vector3(Physics.gravity.x, value, Physics.gravity.z);

            return true;
        }
    }
}
