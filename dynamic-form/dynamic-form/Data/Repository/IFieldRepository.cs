using dynamic_form.Models;

namespace dynamic_form.Data.Repository
{
    public interface IFieldRepository
    {
        Task<ICollection<Field>> FindAll();
    }
}
