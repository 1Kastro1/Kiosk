namespace Kiosk.Формы
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Поставщики
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщики()
        {
            Продукты = new HashSet<Продукты>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int НомерПоставщика { get; set; }

        [StringLength(50)]
        public string ФИОпоставщика { get; set; }

        [StringLength(50)]
        public string НаименованиеФирмы { get; set; }

        public decimal? Телефон { get; set; }

        [StringLength(50)]
        public string АдресФирмы { get; set; }

        public int? НомерТовара { get; set; }

        [Column(TypeName = "date")]
        public DateTime? СрокДоставки { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Продукты> Продукты { get; set; }
    }
}
