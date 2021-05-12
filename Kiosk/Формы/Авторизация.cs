namespace Kiosk.Формы
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Авторизация
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Авторизация()
        {
            Сотрудники = new HashSet<Сотрудники>();
        }

        [Key]
        [StringLength(50)]
        public string Роль { get; set; }

        [StringLength(10)]
        public string Логин { get; set; }

        [StringLength(10)]
        public string Пароль { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудники> Сотрудники { get; set; }
    }
}
