namespace Demo.Tests
{
    using System;
    using NUnit.Framework;
    using Domain;

    [TestFixture]
    public class TrafficLightTests
    {
        [Test]
        public void ToString_ValidData_Success()
        {
            var ServiceStation = new ServiceStation(1, "Mikhail Arisatov", "Tartarovskiy ave. 53");
            var class1 = new TrafficLight(1, "Tartarovskiy ave.-Aviamotornaya st.", ServiceStation);
            var expected = "Tartarovskiy ave.-Aviamotornaya st. Mikhail Arisatov Tartarovskiy ave. 53";

            var actual = class1.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToString_EmptyServiceStation_Success()
        {
            var class1 = new TrafficLight(2, "20 letiya S.E.E.S.");
            var expected = "20 letiya S.E.E.S.";

            var actual = class1.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Ctor_ValidDataEmptyServiceStation_Success()
        {
            Assert.DoesNotThrow(() => _ = new TrafficLight(2, "20 letiya S.E.E.S."));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
        [TestCase("\0")]
        [TestCase("\n")]
        public void Ctor_WrongDataNullLocationStreetEmptyServiceStations_Fail(string wrongLocationStreet)
        {
            // act & assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _ = new TrafficLight(1, wrongLocationStreet));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("  ")]
        [TestCase("\0")]
        [TestCase("\n")]
        public void Ctor_WrongDataNullLocationStreetEmptyServiceStation_Fail(string wrongLocationStreet)
        {
            var ServiceStation = new ServiceStation(1, "Mikhail Arisatov", "Tartarovskiy ave. 53");

            Assert.Throws<ArgumentOutOfRangeException>(() => _ = new TrafficLight(1, wrongLocationStreet));
        }

        [Test]
        public void Ctor_ValidData_Success()
        {
            var ServiceStation = new ServiceStation(1, "Mikhail Arisatov", "Tartarovskiy ave. 53");

            Assert.DoesNotThrow(() => _ = new TrafficLight(1, "Tartarovskiy ave.-Aviamotornaya st.", ServiceStation));
        }
    }
}

