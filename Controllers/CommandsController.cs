using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using PowerliftingREST.Data;
using PowerliftingREST.Dtos;
using PowerliftingREST.Models;

namespace PowerliftingREST.Controllers
{
    //api/commands
    [Route("api/commands")] // api/[controller]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var result = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(result));
        }

        // GET api/commands/id
        [HttpGet("{id}", Name = "GetCommandById")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var result = _repository.GetCommandById(id);
            if (result != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(result));
            }

            return NotFound();
        }

        //POST api/commands
        [HttpPost]
        public ActionResult<CommandCreateDto> CreateCommand(CommandCreateDto cmd)
        {
            var commandModel = _mapper.Map<Command>(cmd);
            _repository.CreateCommand(commandModel);
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);

            return CreatedAtRoute(nameof(GetCommandById), new {Id = commandReadDto.Id}, commandReadDto);
            // return Ok(commandReadDto); 
        }


        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDto cmd)
        {
            var result = _repository.GetCommandById(id);
            if (result == null)
            {
                return NotFound();
            }
            _mapper.Map(cmd, result); // That's all it take to update :D
            _repository.Update(result); // Does not doing anything just for good practises
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public ActionResult PathCommand(int id, JsonPatchDocument<CommandUpdateDto> cmd)
        {
            var result = _repository.GetCommandById(id);
            if (result == null)
            {
                return NotFound();
            }
            var commandToPatch = _mapper.Map<CommandUpdateDto>(result);
            cmd.ApplyTo(commandToPatch, ModelState);
            if (!TryValidateModel(commandToPatch))
            {
                return ValidationProblem();
            }

            _mapper.Map(commandToPatch, result);
            _repository.Update(result); // Does not doing anything just for good practises
            _repository.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCommand(int id)
        {
            var result = _repository.GetCommandById(id);
            if (result == null)
            {
                return NotFound();
            }
            _repository.Delete(result);
            _repository.SaveChanges();
            return NoContent();
        }
    }
}