using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTS_COMMON.ModelDTO.Collection
{
  public  class PredictionCategoriesCollectionDto
    {
        public int Trid { get; set; } = 0; 
        public string CATEGORYNAME { get; set; } = string.Empty;
        public int BookID { get; set; }
    }
}
