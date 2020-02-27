namespace Sesia1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователи
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пользователи()
        {
            Заказ = new HashSet<Заказ>();
            Заказ1 = new HashSet<Заказ>();
        }

        [Key]
        [StringLength(150)]
        public string Логин { get; set; }

        [Required]
        [StringLength(150)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(255)]
        public string Роль { get; set; }

        [StringLength(255)]
        public string Наименование { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ1 { get; set; }
    }
}
