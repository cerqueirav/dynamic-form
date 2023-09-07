using System.ComponentModel.DataAnnotations.Schema;

namespace dynamic_form.Models
{
    [Table("tb_type_field")]
    public class TypeField
    {
        [Column("co_type")]
        public int Id { get; set; }

        [Column("type_name")]
        public string Name { get; set; }
    }
}
