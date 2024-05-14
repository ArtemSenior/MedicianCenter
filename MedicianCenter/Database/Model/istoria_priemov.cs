namespace MedicianCenter.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class istoria_priemov
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public istoria_priemov()
        {
            istoria_priemov1 = new HashSet<istoria_priemov>();
        }

        [Key]
        public int ID_istoria_priemov { get; set; }

        [Required]
        [StringLength(50)]
        public string disease { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_of_priem { get; set; }

        [Required]
        [StringLength(50)]
        public string time { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public int ID_med_card { get; set; }

        public int ID_healing { get; set; }

        public int ID_doctor { get; set; }

        public int? ID_istoria_priemov_redirect { get; set; }

        public virtual doctor doctor { get; set; }

        public virtual healing healing { get; set; }

        public virtual med_card med_card { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<istoria_priemov> istoria_priemov1 { get; set; }

        public virtual istoria_priemov istoria_priemov2 { get; set; }
    }
}
