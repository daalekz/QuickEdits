using NUnit.Framework;
using System;
namespace SwinAdventure
{
//[TestFixture()]
    public class NUnitTestClass
    {
        [Test()]
        public void BagLocatesItems()
        {
            Item myItem = new Item(new String[] { "sword", "blade" }, "sword", "a bronze sword");
            Bag mybag = new Bag(new String[] { "bagg" }, "largebag","Your favorite bag");
            mybag.BagInventory.Put(myItem);
            Assert.AreEqual(myItem, mybag.BagInventory.Fetch("sword"));
            Assert.IsTrue(mybag.BagInventory.HasItem("sword"));
        }
        [Test()]
        public void BagLocatesItself()
        {
            Bag mybag = new Bag(new String[] { "bagg" }, "largebag", "Your favorite bag");
            Assert.AreEqual(mybag.Locate("bagg"), mybag);
        }
        [Test()]
        public void BagDoesntLocateNonexistant()
        {
            Bag mybag = new Bag(new String[] { "bagg" }, "largebag", "Your favorite bag");
            Assert.IsNull(mybag.Locate("backpack"));
        }
        [Test()]
        public void BagFullDescription()
        {
            Bag mybag = new Bag(new String[] { "bagg" }, "largebag", "Your favorite bag");
            Item myItem = new Item(new String[] { "sword", "blade" }, "sword", "a bronze sword");
            mybag.BagInventory.Put(myItem);
            Console.WriteLine(mybag.LongDescription);

            Assert.AreEqual("In the largebag you can see:\n    sword (sword)\n", mybag.LongDescription);
            //Assert.AreEqual("\tsword (sword)\n", mybag.BagInventory.ItemList);      
        }
        //oh no
        [Test()]
        public void BagInBagLocate()
        {
            Bag myparentbag = new Bag(new String[] { "bigbag" }, "largebag", "Your favorite bag");
            Bag mybag2 = new Bag(new String[] { "handbag" }, "largebag", "Your second favorite bag");
            Item myItem = new Item(new String[] { "sword", "blade" }, "sword", "a bronze sword");
            Item myitem2 = new Item(new String[] { "smallersword", "blade" }, "smallersword", "a tiny little sword for on the go");
            
            myparentbag.BagInventory.Put(myItem);
            myparentbag.BagInventory.Put(mybag2);
            mybag2.BagInventory.Put(myitem2);
            
            //parent can locate child bag.
            Assert.AreEqual(mybag2, myparentbag.Locate("handbag"));
            //parent can locate other items within itself
            Assert.AreEqual(myItem, myparentbag.Locate("sword"));
            //parent cannot locate the item in its child bag.
            Assert.IsNull(myparentbag.Locate("smallersword"));
        }
    }
}  
