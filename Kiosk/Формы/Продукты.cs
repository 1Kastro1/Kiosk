namespace Kiosk.Формы
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Продукты
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Продукты()
        {
            Корзина = new HashSet<Корзина>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int НомерПродукта { get; set; }

        [StringLength(50)]
        public string НазваниеПродукта { get; set; }

        public decimal КоличествоПродукта { get; set; }

        [Column(TypeName = "date")]
        public DateTime? СрокГодности { get; set; }

        [Column(TypeName = "money")]
        public decimal? СтоимостьПродукции { get; set; }

        public int? КодЗаказа { get; set; }

        public int? КодПоставщика { get; set; }

        public decimal? Калории { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Корзина> Корзина { get; set; }

        public virtual Поставщики Поставщики { get; set; }
    }
}
