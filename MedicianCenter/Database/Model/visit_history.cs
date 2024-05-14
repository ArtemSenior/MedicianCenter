namespace MedicianCenter.Database.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class visit_history
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_doctor { get; set; }

        [StringLength(50)]
        public string surname { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string middle_name { get; set; }

        public int? cabinet { get; set; }

        [StringLength(15)]
        public string work_number { get; set; }

        [StringLength(50)]
        public string specialization { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_istoria_priemov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string disease { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime date_of_priem { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string time { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string status { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_med_card { get; set; }

        [StringLength(50)]
        public string Expr1 { get; set; }

        [StringLength(50)]
        public string Expr2 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Expr3 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_of_birth { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(15)]
        public string phone_number { get; set; }

        [StringLength(50)]
        public string number_passport { get; set; }

        [StringLength(50)]
        public string seria_passport { get; set; }

        [StringLength(50)]
        public string snils { get; set; }

        [StringLength(50)]
        public string place_of_residence { get; set; }

        [StringLength(50)]
        public string settlenment { get; set; }

        [StringLength(50)]
        public string street { get; set; }

        public int? number_house { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int number_room { get; set; }

        [StringLength(50)]
        public string profession { get; set; }
    }
}
