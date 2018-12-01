using NUnit.Framework;
using System;
namespace SwinAdventure
{
    //[TestFixture()]
    public class NUnitTestClass2
    {
       [Test()]
        public void LookAtMe()
        {
            Player myplayer = new Player("gareth", "our battered adventurer");
            LookCommand mycommand = new LookCommand();
            Assert.AreEqual("You are carrying:\n", mycommand.Execute(myplayer, new String[] { "look at inventory" }));
        }
        [Test()]
        public void LookAtGem()
        {
            Player myplayer = new Player("gareth", "our battered adventurer");
            Item myItem = new Item(new String[] { "gem", "jewl" }, "gem", "a shiny gem");
            myplayer.PlayerInventory.Put(myItem);
            LookCommand mycommand = new LookCommand();
            Assert.AreEqual("a shiny gem", mycommand.Execute(myplayer, new String[] { "look at gem in inventory" }));
        }
        [Test()]
        public void LookatUnk()
        {
            Player myplayer = new Player("gareth", "our battered adventurer");
            Item myItem = new Item(new String[] { "gem", "jewl" }, "gem", "a shiny gem");
            LookCommand mycommand = new LookCommand();
            Assert.AreEqual("I cannot find the gem",mycommand.Execute(myplayer, new String[] { "look at gem" }));
        }
        [Test()]
        public void LookAtGemInBag()
        {
            Player myplayer = new Player("gareth", "our battered adventurer");
            Item myItem = new Item(new String[] { "gem", "jewl" }, "gem", "a shiny gem");
            Bag mybag = new Bag(new String[] { "bagg", "sack" }, "bagg", "a knapsack");
            mybag.BagInventory.Put(myItem);
            myplayer.PlayerInventory.Put(mybag);
            LookCommand mycommand = new LookCommand();
            Assert.AreEqual("a shiny gem", mycommand.Execute(myplayer, new String[] { "look at gem in bagg" }));
        }
        [Test()]
        public void LookAtGemInNoBag()
        {
            Player myplayer = new Player("gareth", "our battered adventurer");
            Item myItem = new Item(new String[] { "gem", "jewl" }, "gem", "a shiny gem");
            LookCommand mycommand = new LookCommand();
            Assert.AreEqual("I cannot find the bag", mycommand.Execute(myplayer, new String[] { "look at gem in bag" }));
        }
        [Test()]
        public void LookAtNoGemInBag()
        {
            Player myplayer = new Player("gareth", "our battered adventurer");
            Item myItem = new Item(new String[] { "gem", "jewl" }, "gem", "a shiny gem");
            Bag mybag = new Bag(new String[] { "bagg", "sack" }, "bagg", "a knapsack");
            myplayer.PlayerInventory.Put(mybag);
            LookCommand mycommand = new LookCommand();
            Assert.AreEqual("I cannot find the gem in bagg", mycommand.Execute(myplayer, new String[] { "look at gem in bagg" }));
        }
        [Test()]
        public void InvalidLook()
        {
            Player myplayer = new Player("gareth", "our battered adventurer");
            LookCommand mycommand = new LookCommand();
            Assert.AreEqual("What do you want to look at?", mycommand.Execute(myplayer, new String[] { "look around" }));
            Assert.AreEqual("Error in look input", mycommand.Execute(myplayer, new String[] { "hello" }));
            Assert.AreEqual("What do you want to look in?", mycommand.Execute(myplayer, new String[] { "look at gem at inventory" }));
        }
    }
}