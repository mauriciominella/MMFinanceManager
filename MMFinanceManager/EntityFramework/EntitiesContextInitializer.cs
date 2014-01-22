using MMFinanceManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMFinanceManager.EntityFramework
{
    public class EntitiesContextInitializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            AddPredefinedCategories(context);
            context.SaveChanges();

        }

        private static void AddPredefinedCategories(EFDbContext context)
        {
            List<Category> categories = new List<Category>
            {
                new Category {Id=1, Name="Salário", CreatedDate = DateTime.Now, Type = TransactionType.Revenue},
                new Category {Id=2, Name="Vale Combustível", CreatedDate = DateTime.Now, Type = TransactionType.Revenue},
                new Category {Id=3, Name="Vale Refeição", CreatedDate = DateTime.Now, Type = TransactionType.Revenue},
                new Category {Id=4, Name="Hora Extra", CreatedDate = DateTime.Now, Type = TransactionType.Revenue},
                new Category {Id=5, Name="Academia", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=6, Name="Alimentação", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=7, Name="Carro", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=8, Name="Celular", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=9, Name="Cerveja", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=10, Name="Compras", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=11, Name="Entretenimento", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=12, Name="Família", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=13, Name="Mercado", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=14, Name="Moradia", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=15, Name="Presentes", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=16, Name="Roupa", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=17, Name="Bike", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=18, Name="Cidadania Italiana", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=19, Name="Estudos", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=20, Name="Klotz Bier", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=21, Name="Música", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=22, Name="Saúde", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=23, Name="Tarifas Bancárias", CreatedDate = DateTime.Now, Type = TransactionType.Expense},
                new Category {Id=24, Name="Viagens", CreatedDate = DateTime.Now, Type = TransactionType.Expense},

            };

            // add data into context and save to db
            foreach (Category cat in categories)
            {
                context.Categories.Add(cat);
            }
        }
    }
}
