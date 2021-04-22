using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace hc_people_core.Models
{
    public class People
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string name { get; set; }

        public string address { get; set; }

        public int age { get; set; }

        public string interests { get; set; }

        public string avatar { get; set; }

    }

}
