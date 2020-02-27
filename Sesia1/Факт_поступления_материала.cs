namespace Sesia1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Факт поступления материала")]
    public partial class Факт_поступления_материала
    {
        [Key]
        [StringLength(50)]
        public string Номер_поставки { get; set; }

        [StringLength(50)]
        public string Закупаемый_материал { get; set; }

        [StringLength(50)]
        public string Количество { get; set; }

        [StringLength(50)]
        public string Закупочная_цена { get; set; }

        [StringLength(50)]
        public string Сумма { get; set; }
    }
}
