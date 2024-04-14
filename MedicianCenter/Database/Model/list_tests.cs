namespace MedicianCenter.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class list_tests
    {
        [Key]
        public int ID_list_tests { get; set; }

        [Required]
        [StringLength(300)]
        public string name { get; set; }

        public string opisanie { get; set; }

        public int? ID_med_card { get; set; }
    }
}
