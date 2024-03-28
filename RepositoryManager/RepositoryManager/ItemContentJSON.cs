using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryManager
{
    class ItemContentJSON : ItemContent
    {
        private string itemName;
        private string itemContent;
        private int itemType;

        public ItemContentJSON(string itemName, string itemContent, int itemType) : base(itemName, itemContent, itemType)
        {
            
        }
        public override bool Validate()
        {
            // validate JSON content here
            return true;
        }
    }
}
