namespace DataLayer.DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rent")]
    public partial class Rent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RentId { get; set; }

        [Required]
        [StringLength(200)]
        public string RentName { get; set; }

        [Required]
        [StringLength(15)]
        public string dogovor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateStart { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateEnd { get; set; }

        [StringLength(15)]
        public string EDRPOU { get; set; }

        [Required]
        [StringLength(10)]
        public string Telephon { get; set; }

        [Required]
        [StringLength(64)]
        public string ContactaName { get; set; }

        [Required]
        [StringLength(200)]
        public string LegalAddress { get; set; }

        [Required]
        [StringLength(200)]
        public string RentAddress { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SquareArea { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Credit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Debet { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Longitude { get; set; }
    }
}
