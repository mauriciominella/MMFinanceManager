using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.Model
{
    public class Transaction
    {
        [Key]
        public long Id { get; set; }

        [ForeignKey("Category")]
        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }
       
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public DateTime CreationDate { get; set; }

        public TransactionType Type { get; set; }

        
    }
}
