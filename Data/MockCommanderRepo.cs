using System.Collections.Generic;
using PowerliftingREST.Models;

namespace PowerliftingREST.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var Commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Walk a dog", Line = "Test", Platform = "test"},
                new Command {Id = 0, HowTo = "Walk a dog", Line = "Test", Platform = "test"},
                new Command {Id = 0, HowTo = "Walk a dog", Line = "Test", Platform = "test"}
            };
            return Commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command
            {
                Id = 0, HowTo = "Walk a dog", Line = "Test", Platform = "test"
            };
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}