using NUnit.Framework;

<<<<<<< HEAD

namespace TestTennis
{
    public class Tests
    { 

    private Match _match;
    
        [SetUp]
        public void Setup()
        {
          _match = new Match ("Player1","Player2");
        }

        [Test]
        public void TestWin()
        {

            _match.Player1.AddScore();
            _match.Player1.AddScore();
            _match.Player1.AddScore();
            _match.Player1.AddScore();

            var result = _match.GetMatchScore(_match.Player1.Score, 0);
            Assert.AreEqual(result, "Player1 Win", "Player2 Lose");
=======
namespace TestTennis
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
>>>>>>> b91a3f984a18ef7a31246c24d3ed7487712aed78
        }
    }
}