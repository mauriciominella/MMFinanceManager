using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Model
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
