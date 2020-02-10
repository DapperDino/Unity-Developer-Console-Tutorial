using DapperDino.UDCT.Utilities.DeveloperConsole;
using DapperDino.UDCT.Utilities.DeveloperConsole.Commands;
using Moq;
using NUnit.Framework;
using System;

namespace Tests.Utilities
{
    public class DeveloperConsoleTests
    {
        private const string prefix = "/";

        [Test]
        public void ProcessCommand_CommandExists_CommandIsProcessed()
        {
            var mock = new Mock<IConsoleCommand>();
            mock.Setup(x => x.CommandWord).Returns("hi");
            var console = new DeveloperConsole(prefix, new IConsoleCommand[] { mock.Object });

            console.ProcessCommand($"{prefix}hi");

            mock.Verify(x => x.Process(Array.Empty<string>()), Times.Once());
        }

        [Test]
        public void ProcessCommand_CommandDoesNotExist_CommandIsNotProcessed()
        {
            var mock = new Mock<IConsoleCommand>();
            var console = new DeveloperConsole(prefix, Array.Empty<IConsoleCommand>());

            console.ProcessCommand($"{prefix}hi");

            mock.Verify(x => x.Process(Array.Empty<string>()), Times.Never());
        }
    }
}
