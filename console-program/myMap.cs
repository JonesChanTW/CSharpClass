using System;
using System.Collections.Generic;

namespace MyMapSpace
{
    
    public class MyMap<TKey, TVal>
    {
        struct MapItem
        {
            public TKey keyVal;
            public TVal val;
        }
        List<MapItem> oCotainer = new List<MapItem>();
        public MyMap()
        {

        }

        public void AddItem(TKey key, TVal val)
        {
            MapItem item = new MapItem();

            item.keyVal = key;
            item.val = val;
            oCotainer.Add(item);
        }

        public void Find(TKey key, out TVal val)
        {
            MapItem item = oCotainer.Find( x => { return x.keyVal.Equals(key); });

            val = item.val;
        }
    }
}