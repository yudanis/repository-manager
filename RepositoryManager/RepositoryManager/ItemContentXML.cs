using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryManager
{
    class ItemContentXML : ItemContent
    {
        public ItemContentXML(string itemName, string itemContent, int itemType) : base(itemName, itemContent, itemType)
        {
            
        }
        public override bool Validate()
        {
            // validate XML content here
            return true;
        }
    }
}
