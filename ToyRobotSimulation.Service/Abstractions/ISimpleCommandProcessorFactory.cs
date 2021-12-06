using ToyRobotSimulation.Service;
using ToyRobotSimulation.Service.Abstractions;

namespace ToyRobotSimulation.Client
{
    public interface ISimpleCommandProcessorFactory
    {
        ICommandProcessor GetProcessor(CommandType commandType, string[] commands);
    }
}