using System.ComponentModel.DataAnnotations.Schema;

namespace dynamic_form.Models
{
    [Table("tb_field")]
    public class Field
    {
        [Column("co_field")]
        public int Id { get; set; }

        [Column("field_name")]
        public string Name { get; set ;}

        [Column("co_type")]
        public int TypeId { get; set ;}

        [Column("active")]
        public bool Active { get; set; }

        public virtual TypeField Type { get; set; }
    }
}
