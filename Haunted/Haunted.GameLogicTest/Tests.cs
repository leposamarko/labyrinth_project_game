using Haunted.GameModel;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haunted.GameLogicTest
{
    [TestFixture]
    public class Tests
    {
        private GameLogic.GameLogic logic;
        private Haunted.GameModel.HauntedModel model;
        private Haunted.Repository.StorageRepository repo;

        [OneTimeSetUp]
        public void SetUp()
        {
            this.model = new GameModel.HauntedModel(1024, 500);
            this.repo = new Repository.StorageRepository();
            this.logic = new GameLogic.GameLogic(this.model, "Haunted.map.lab.lvl", this.repo);
        }

        [TestCase(4)]
        public void FourGhostInTheMap(int db)
        {
            // this.logic.Initmodel("Haunted.map.lab.lvl");
            Assert.That(this.model.Ghosts.Count, Is.EqualTo(db));
        }

        [TestCase(3)]
        public void ThreeKeyInTheMapp(int db)
        {
            // this.logic.Initmodel("Haunted.map.lab.lvl");
            Assert.That(this.model.Keys.Count, Is.EqualTo(db));
        }

        [TestCase(1, 0)]
        public void PlayerIsMoving(int x, int y)
        {
            this.logic.Move(x, y);
            Assert.That(this.model.Player.Area.X, Is.EqualTo(3));
        }

        [Test]
        public void GhostIsMoving() 
        {

        }
    }
}
