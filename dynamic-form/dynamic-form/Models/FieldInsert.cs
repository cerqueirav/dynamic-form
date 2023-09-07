namespace dynamic_form.Models
{
    [Serializable]
    public class FieldInsert
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
    }
}
