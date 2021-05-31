using System;
using NUnit.Framework;

namespace Business.Tests
{
    [TestFixture]
    public class CharacterTests
    {
        #region String Tests

        [Test]
        public void ShouldSetName()
        {
            const string expected = "John";
            var c = new Character(Type.Elf, expected);

            Assert.That(c.Name, Is.EqualTo(expected));
            Assert.That(c.Name, Is.Not.Empty);
            Assert.That(c.Name, Contains.Substring("ohn"));
        }

        [Test]
        public void ShouldSetNameCaseInsensitive()
        {
            const string expectedUpperCase = "JOHN";
            const string expectedLowerCase = "john";

            var c = new Character(Type.Elf, expectedUpperCase);
            Assert.That(c.Name, Is.EqualTo(expectedLowerCase).IgnoreCase);
        }

        #endregion

        #region Numerical Tests

        [Test]
        public void DefaultHealthIs100()
        {
            var c = new Character(Type.Elf);

            const int expectedHealth = 100;
            Assert.That(c.Health, Is.EqualTo(expectedHealth));
            Assert.That(c.Health, Is.Positive);
            //Assert.That(c.Health, Is.Negative);
        }

        [Test]
        public void Elf_SpeedIsCorrect()
        {
            var c = new Character(Type.Elf);

            const double expectedSpeed = 1.7;
            Assert.That(c.Speed, Is.EqualTo(expectedSpeed));
        }

        [Test]
        public void Ork_SpeedIsCorrect()
        {
            var c = new Character(Type.Ork);

            const double expectedSpeed = 1.4;
            Assert.That(c.Speed, Is.EqualTo(expectedSpeed));
        }

        [Test]
        public void Ork_SpeedIsCorrectWithTolerance()
        {
            var c = new Character(Type.Ork);

            const double expectedSpped = 0.3 + 1.1; // This procedure 1.400000001
            //Assert.That(c.Speed, Is.EqualTo(expectedSpped));
            Assert.That(c.Speed, Is.EqualTo(expectedSpped).Within(0.5));
            Assert.That(c.Speed, Is.EqualTo(expectedSpped).Within(1).Percent);
        }

        #endregion

        #region Null ans Booleans
        [Test]
        public void DefaultNameIsNull()
        {
            var c = new Character(Type.Elf);
            Assert.That(c.Name, Is.Null);
        }

        [Test]
        public void IsDead_KillCharacter_ReturnTrue()
        {
            var c = new Character(Type.Elf);

            c.Damage(500);

            Assert.That(c.IsDead, Is.True);
        }
        #endregion

        #region Collections
        [Test]
        public void CollectionsTests()
        {
            var c = new Character(Type.Elf);
            c.Weaponry.Add("Knife");
            c.Weaponry.Add("Pistol");

            Assert.That(c.Weaponry, Is.All.Not.Empty);
            Assert.That(c.Weaponry, Contains.Item("Knife"));
            Assert.That(c.Weaponry, Has.Exactly(2).Length);
            Assert.That(c.Weaponry, Has.Exactly(1).EndsWith("tol"));
            Assert.That(c.Weaponry, Is.Unique);
            Assert.That(c.Weaponry, Is.Ordered);

            var c2 = new Character(Type.Elf);

            c2.Weaponry.Add("Knife");
            c2.Weaponry.Add("Pistol");
            Assert.That(c.Weaponry, Is.EquivalentTo(c2.Weaponry));
        }

        #endregion

        #region Reference Equality

        [Test]
        public void SameCharacters_AreEqualByReference()
        {
            var c1 = new Character(Type.Elf);
            var c2 = c1;

            Assert.That(c1, Is.SameAs(c2));
        }

        #endregion

        #region Types

        [Test]
        public void TestObjectOfCharacterType()
        {
            object c = new Character(Type.Elf);
            Assert.That(c, Is.TypeOf<Character>());
        }

        #endregion

        #region Ranges

        [Test]
        public void DefaultCharacterArmorShouldBeGreaterThan30AndLessThan100()
        {
            var c = new Character(Type.Elf);

            Assert.That(c.Armor, Is.GreaterThan(30).And.LessThan(100));
            Assert.That(c.Armor, Is.InRange(30, 100));
        }

        #endregion

        #region Exceptions

        [Test]
        public void Damage_1000_ThrowsArgumentOutOfRange()
        {
            var c = new Character(Type.Elf);

            Assert.Throws<ArgumentOutOfRangeException>(() => c.Damage(1001));
            Assert.That(() => c.Damage(1001), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Damage_1000_ThrowsArgumentOutOfRange_BadWay()
        {
            var c = new Character(Type.Elf);

            Assert.Throws<ArgumentOutOfRangeException>(() => c.Damage(1001));
            Assert.That(() => c.Damage(1001), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        #endregion
    }
}
