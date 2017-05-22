namespace AccesoDB.codeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITEM_TITULO
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Simbolo { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public decimal? PrecioApertura { get; set; }

        public decimal? Minimo { get; set; }

        public decimal? Maximo { get; set; }

        public decimal? UltimoCierre { get; set; }

        public long FK_Item_Titulo_Type { get; set; }

        public virtual ITEM_TITULO_TYPE ITEM_TITULO_TYPE { get; set; }
    }
}
