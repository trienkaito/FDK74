using FBK74App.DAO;
using FBK74App.models;
using static System.Reflection.Metadata.BlobBuilder;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace FBK74App.Repository
{
    public class RegisteredFootballFieldRepository : IRegisteredFootballFieldRepository
    {
        public async Task Add(RegisteredFootballField rff)
        {
            await RegisteredFootballFieldsDAO.Instance.Add(rff);
        }
        public async Task<RegisteredFootballField> GetRFFbyId(int id)
        {
            return await RegisteredFootballFieldsDAO.Instance.GetRFFbyId(id);
        }
    }
}
