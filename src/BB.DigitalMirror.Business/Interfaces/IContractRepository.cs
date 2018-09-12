using BB.DigitalMirror.API.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BB.DigitalMirror.Business
{
    public interface IContractRepository
    {
       Task<List<ContractModel>> GetContracts();

       Task<ContractModel> GetContractById(int id);

       Task<ContractModel> CreateContract(ContractRequest request);
    }
}