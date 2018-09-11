using BB.DigitalMirror.API.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BB.DigitalMirror.Business
{
    public interface IContractRepository
    {
       Task<List<Contract>> GetContracts();

       Task<Contract> GetContractById(int id);

       Task<Contract> CreateContract(ContractRequest request);
    }
}