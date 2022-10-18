using Commun;

namespace TestProject1
{
    public class BasicTests
    {
        [Fact]
        public void BasicHealingIncreasesHP()
        {
            Player p = new Player() { HP = 2};
            var h = new Healing(){Strength = 5};
            //h.Strength = 5

            Assert.Equal(2, p.HP);

            h.Cast(p);

            Assert.Equal(7, p.HP);


        }
    }
}