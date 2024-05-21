namespace MedicianCenter.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestResult")]
    public partial class TestResult
    {
        public long Id { get; set; }

        [Required]
        public string Key { get; set; }

        [Required]
        public string Value { get; set; }

        public int TestId { get; set; }

        public int TemplateId { get; set; }

        public virtual list_tests list_tests { get; set; }

        public virtual Template Template { get; set; }
    }
}
