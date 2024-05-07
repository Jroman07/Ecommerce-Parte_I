using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Category
{
    public class SvCategory : ISvCategory
    {
        #region reads
        public List<Category> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int IdCategory)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region writes
        public Category AddCategory(Category category)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}