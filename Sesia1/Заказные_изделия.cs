namespace Sesia1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Заказные изделия")]
    public partial class Заказные_изделия
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Артикул_изделия { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Номер_заказа { get; set; }

        public double Количество { get; set; }

        public virtual Заказ Заказ { get; set; }

        public virtual Изделия Изделия { get; set; }
    }
}
