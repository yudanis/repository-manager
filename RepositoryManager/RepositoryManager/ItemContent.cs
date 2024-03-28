using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryManager
{
    abstract class ItemContent
    {
        string name;
        string content;
        int type;
        public ItemContent(string name, string content, int type)
        {
            this.name = name;
            this.content = content;
            this.type = type;
        }

        public string GetContent()
        {
            return this.content;
        }

        public int GetType()
        {
            return this.type;
        }

        public abstract bool Validate();
    }
}
