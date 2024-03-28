using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryManager
{
    public class RepositoryManager
    {
        static RepositoryManager instance = null;

        public static RepositoryManager GetInstance()
        {
            if (instance == null)
                instance = new RepositoryManager();

            return instance;
        }
        Dictionary<string, ItemContent> contents;
        public RepositoryManager()
        {
            contents = new Dictionary<string, ItemContent>();
        }

        public void Register(string itemName, string itemContent, int itemType)
        {
            if (contents.ContainsKey(itemName))
                throw new ArgumentException("Item is already exist and can not be override");

            ItemContent content = null;
            if (itemType == 0)
            {
                content = new ItemContentJSON(itemName, itemContent, itemType);
            }
            else
                content = new ItemContentXML(itemName, itemContent, itemType);

            if(content.Validate())
                contents.Add(itemName, content);
        }

        public string Retrieve(string itemName)
        {
            if (contents.ContainsKey(itemName))
                return contents[itemName].GetContent();
            else
                return null;

        }

        public int GetType(string itemName)
        {
            return contents[itemName].GetType();
        }

        public void Deregister(string itemName)
        {
            contents.Remove(itemName);
        }

        void initialize()
        {
        }
    }
}
