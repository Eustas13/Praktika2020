namespace Sesia1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказ()
        {
            Заказные_изделия = new HashSet<Заказные_изделия>();
        }

        [Key]
        [StringLength(150)]
        public string Номер { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата { get; set; }

        [Required]
        [StringLength(255)]
        public string Этап_выполнения { get; set; }

        [Required]
        [StringLength(150)]
        public string Заказчик { get; set; }

        [StringLength(150)]
        public string Менеджер { get; set; }

        public decimal? Стоимость { get; set; }

        public virtual Пользователи Пользователи { get; set; }

        public virtual Пользователи Пользователи1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказные_изделия> Заказные_изделия { get; set; }
    }
}
