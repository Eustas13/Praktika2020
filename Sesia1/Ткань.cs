namespace Sesia1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ткань
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ткань()
        {
            Склад_ткани = new HashSet<Склад_ткани>();
            Изделия = new HashSet<Изделия>();
        }

        [Key]
        [StringLength(150)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(255)]
        public string Наименование { get; set; }

        [StringLength(255)]
        public string Цвет { get; set; }

        [StringLength(255)]
        public string Рисунок { get; set; }

        [Column(TypeName = "image")]
        public byte[] Изображение { get; set; }

        [StringLength(255)]
        public string Состав { get; set; }

        [Required]
        [StringLength(150)]
        public string Ширина { get; set; }

        [Required]
        [StringLength(150)]
        public string Длина { get; set; }

        [Required]
        [StringLength(150)]
        public string Цена { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад_ткани> Склад_ткани { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Изделия> Изделия { get; set; }
    }
}
