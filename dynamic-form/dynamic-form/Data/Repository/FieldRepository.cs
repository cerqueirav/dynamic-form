using dynamic_form.Data.Context;
using dynamic_form.Models;
using Microsoft.EntityFrameworkCore;

namespace dynamic_form.Data.Repository
{
    public class FieldRepository : IFieldRepository
    {
        protected readonly DynamicContext _context;

        public FieldRepository(DynamicContext context)
        {
            _context = context;
        }

        public async virtual Task<ICollection<Field>> FindAll()
        {
            return await _context.Fields.Include(field => field.Type).ToListAsync();
        }
    }
}