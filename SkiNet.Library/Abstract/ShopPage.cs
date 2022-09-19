using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract
{
    public abstract class ShopPage
    {
        public string Title { get; }
        public void SetSort(string sortOption)
        {

        }
        public string ShopSortComponent Sort { get; }

        public List<Boot> Boots { get; }

    }
}
