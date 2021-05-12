namespace Kiosk.Формы
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
            Корзина = new HashSet<Корзина>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int КодЗаказа { get; set; }

        [Column(TypeName = "money")]
        public decimal? СтоимостьЗаказа { get; set; }

        public decimal? срокВыполнения { get; set; }

        public int? КодСотрудника { get; set; }

        [StringLength(50)]
        public string НазваниеПродукта { get; set; }

        public int? кодКлиента { get; set; }

        public virtual Клиент Клиент { get; set; }

        public virtual Сотрудники Сотрудники { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Корзина> Корзина { get; set; }
    }
}
