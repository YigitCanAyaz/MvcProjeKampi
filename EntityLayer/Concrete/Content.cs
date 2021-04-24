using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        // ContentYazar
        // ContentBaşlık
        // İlişkili alanlardan gelen değerlere kısıtlama getirmiyoruz
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        // ? eklersek nullable type olur
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
