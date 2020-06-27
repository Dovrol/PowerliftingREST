using System.Collections.Generic;
using PowerliftingREST.Models;

namespace PowerliftingREST.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void Update(Command cmd);
        void Delete(Command cmd);
    } 
}