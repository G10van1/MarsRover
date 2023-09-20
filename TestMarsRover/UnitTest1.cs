namespace TestMarsRover
{
    public class Tests
    {
        Rover rover = new Rover();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.That(rover.Execute("MMMMMMMMMM"), Is.EqualTo("0:0:N"));
            Assert.That(rover.Execute("R"), Is.EqualTo("0:0:E"));
            Assert.That(rover.Execute("M"), Is.EqualTo("1:0:E"));
            Assert.That(rover.Execute("L"), Is.EqualTo("1:0:N"));
            Assert.That(rover.Execute("M"), Is.EqualTo("1:1:N"));
            Assert.That(rover.Execute("MM"), Is.EqualTo("1:3:N"));
            Assert.That(rover.Execute("RM"), Is.EqualTo("2:3:E"));
            Assert.That(rover.Execute("MMMMMMMM"), Is.EqualTo("0:0:N"));
            Assert.That(rover.Execute("RMMMMMLMMMMM"), Is.EqualTo("5:5:N"));
            Assert.Pass();
        }
    }
}