using Core.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Client.Interface
{
    public interface IIpfsApiClient
    {
        Task<IpfsDataDto> GetParsedDataByContractUsingIpfsClient(string data);
    }
}
