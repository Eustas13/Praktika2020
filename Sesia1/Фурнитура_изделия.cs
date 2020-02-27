namespace Sesia1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Фурнитура изделия")]
    public partial class Фурнитура_изделия
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Артикул_фурнитуры { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Артикул_изделия { get; set; }

        [Required]
        [StringLength(255)]
        public string Размещение { get; set; }

        public double? Ширина { get; set; }

        public double? Длина { get; set; }

        public double? Поворот { get; set; }

        public int Количество { get; set; }

        public virtual Изделия Изделия { get; set; }

        public virtual Фурнитура Фурнитура { get; set; }
    }
}
