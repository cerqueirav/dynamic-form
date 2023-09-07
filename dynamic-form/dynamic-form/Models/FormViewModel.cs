namespace dynamic_form.Models
{
    public class FormViewModel
    {
        public ICollection<Field> components;
        
        public FormViewModel() 
        {
            components = new List<Field>();
        }
    }
}
