using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract
{
    public abstract class ShopSortComponent
    {
        public string CurrentSort { get; }
        public string ResultCountMessage { get;  }
        public void SetSort(string option)
        {

        }
    }
}
