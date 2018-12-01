using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace SwinAdventure
{
public class Bag : Item, IHaveInventory
    {
        private Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base (ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public override string LongDescription
        {
            get
            {
                return "In the " + Name + " you can see:\n" + _inventory.ItemList;
            }
        }

        public Inventory BagInventory
        {
            get
            {
                return _inventory;
            }
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
        }
    }
     public class Inventory
    {
        private List<Item> _items;

        public string ItemList
        {
            get
            {
                string output = "";
                foreach (Item i in _items)
                {
                    output += "    " + i.ShortDescription + "\n";
                }
                return output;
            }
        }

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            foreach (Item i in _items)
            {
                if (i.FirstID == id) return true;
            }

            return false;
        }

        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        public Item Take(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    Item temp = i;
                    _items.Remove(i);
                    return temp;
                }
            }

            return null;
        }

        public Item Fetch(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id)) return i;
            }
            
            return null;
        }
    }
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void BagLocatesItems()
        {
            Item myItem = new Item(new String[] { "sword", "blade" }, "sword", "a bronze sword");
            Bag mybag = new Bag();
            mybag.Put(myitem);
            Assert(
        }
    }
}
