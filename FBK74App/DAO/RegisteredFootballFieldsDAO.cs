using FBK74App.models;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace FBK74App.DAO
{
    public class RegisteredFootballFieldsDAO : SingletonBase<RegisteredFootballFieldsDAO>
    {
        public async Task<RegisteredFootballField> GetRFFbyId(int id)
        {
            var rff = await _context.RegisteredFootballFields.SingleOrDefaultAsync(c => c.Id == id);
            if (rff == null)
            {
                return null;
            }
            return rff;
        }
        public async Task Add(RegisteredFootballField rff)
        {
            _context.RegisteredFootballFields.Add(rff);
            await _context.SaveChangesAsync();
        }
    }
}
