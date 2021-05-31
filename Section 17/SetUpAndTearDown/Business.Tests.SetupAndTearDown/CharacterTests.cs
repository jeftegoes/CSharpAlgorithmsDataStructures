using System;
using NUnit.Framework;

namespace Business.Tests.SetupAndTearDown
{
    [TestFixture]
    public class CharacterTests
    {
        private Character _character;

        [SetUp]
        public void Setup()
        {
            _character = new Character(Type.Elf);
        }

        public void Teardown()
        {
            _character.Dispose();
            _character = null;
        }

        [Test]
        public void IsDead_KillCharacter_ReturnsTrue()
        {
            _character.Damage(500);
            Assert.That(_character.IsDead, Is.True);
        }

        [Test]
        public void IsDead_DefaultCharacter_ReturnsFalse()
        {
            Assert.IsFalse(_character.IsDead);
        }

        [Test]
        public void Health_Damage1000OnElf_Returns45()
        {
            _character.Damage(100);
            Assert.That(_character.Health, Is.EqualTo(45));
        }

        [Test]
        public void Health_Damage80OnElf_Returns65()
        {
            _character.Damage(80);
            Assert.That(_character.Health, Is.EqualTo(65));
        }
    }
}