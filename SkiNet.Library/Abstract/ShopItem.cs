using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiNet.Library.Abstract
{
    public abstract class ShopItem : Search
    {
        
            public string Name { get; }
            public string ImgSrc { get; }
            public string Price { get; }

        
    }
