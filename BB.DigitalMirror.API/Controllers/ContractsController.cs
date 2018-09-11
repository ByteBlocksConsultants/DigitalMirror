using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BB.DigitalMirror.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BB.DigitalMirror.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly IContractRepository _contractRepository;

        public ContractsController(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository ?? throw new ArgumentNullException(nameof(contractRepository));
        }

        // GET: api/Contracts
        [HttpGet(Name = "Get")]
        [ProducesResponseType(200, Type = typeof(List<Contract>))]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IList<Contract>>> Get()
        {
            var response = await _contractRepository.GetContracts();
            if (!response.Any())
            {
                return NotFound();
            }
            return response;
        }

        // GET: api/Contracts/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(200, Type = typeof(Contract))]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Contract>> Get(int id)
        {
            var response = await _contractRepository.GetContractById(id);
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }

        // POST: api/Contracts
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ContractRequest request)
        {
            if (request == null)
            {
                BadRequest();
            }

            await _contractRepository.CreateContract(request);
             
            return Created("api/Contracts", null);           
        }
         
        [HttpPut("{id}")]
        public void Put()
        {
            StatusCode(StatusCodes.Status405MethodNotAllowed);
        }
         
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            StatusCode(StatusCodes.Status405MethodNotAllowed);
        }
    }
}
