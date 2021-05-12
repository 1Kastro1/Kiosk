namespace Kiosk.Формы
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сотрудники
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудники()
        {
            Заказ = new HashSet<Заказ>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Табельныйномер { get; set; }

        [StringLength(50)]
        public string ФИО { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ДатаРождения { get; set; }

        [StringLength(50)]
        public string Адрес { get; set; }

        public decimal? Номер { get; set; }

        [Column(TypeName = "money")]
        public decimal? Зарплата { get; set; }

        [StringLength(50)]
        public string Роль { get; set; }

        public virtual Авторизация Авторизация { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ> Заказ { get; set; }
    }
}
