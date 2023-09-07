namespace dynamic_form.Models
{
    public class FormViewModel
    {
        public List<Field> components;
        
        public FormViewModel() 
        {
            components = new List<Field>();
        }
    }
}
