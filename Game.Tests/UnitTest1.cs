using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Media;

namespace Game.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TakeDamage_ReducesHealth()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.TakeDamage(10);

            //Assert
            Assert.AreEqual(90, player.CurrentHealth);
            
        }

        [TestMethod]
        public void TakeDamage_HealthDoesNotGoBelowZero()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.TakeDamage(110);

            //Assert
            Assert.AreEqual(0, player.CurrentHealth);

            
        }

        [TestMethod]
        public void TakeDamage_ZeroDamageDoesNothing()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.TakeDamage(0);

            //Assert
            Assert.AreEqual(100, player.CurrentHealth);

        }

        [TestMethod]
        public void Heal_IncreaseHealth()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.TakeDamage(50);
            player.Heal(10);

            //Assert
            Assert.AreEqual(60, player.CurrentHealth);

        }

        [TestMethod]
        public void Heal_HealthDoesNotExceedMaxHealth()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.TakeDamage(50);
            player.Heal(60);

            //Assert
            Assert.AreEqual(100, player.CurrentHealth);

        }

        [TestMethod]
        public void Heal_HealAtFullDoesNothing()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.Heal(60);

            //Assert
            Assert.AreEqual(100, player.CurrentHealth);

        }

        [TestMethod]
        public void Move_MovesCorrectlyOnXandY()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.Move(deltaX: 5, deltaY: 5);

            //Assert
            Assert.AreEqual(15, player.X);
            Assert.AreEqual(15, player.Y);

        }

        [TestMethod]
        public void Move_MoveByZeroZeroDoesNothing()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.Move(deltaX: 0, deltaY: 0);

            //Assert
            Assert.AreEqual(10, player.X);
            Assert.AreEqual(10, player.Y);

        }

        [TestMethod]
        public void Move_NegativeMovementWorks()
        {

            //Arrange
            Player player = new Player(maxHealth: 100, startX: 10, startY: 10);

            //Act
            player.Move(deltaX: -5, deltaY: -5);

            //Assert
            Assert.AreEqual(5, player.X);
            Assert.AreEqual(5, player.Y);

        }
    }
}
