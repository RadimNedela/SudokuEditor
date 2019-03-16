using Domain;
using Xunit;

namespace DomainTests
{
    public class DevitkaTests
    {
        [Fact]
        public void EachRowOnPlocha_Contains9Policek()
        {
            var plocha = new Plocha();

            var rows = plocha.Rows;

            foreach (var devitka in rows)
                Assert.Equal(9, devitka.Policka.Length);
        }

        [Fact]
        public void EachColumnOnPlocha_Contains9Policek()
        {
            var plocha = new Plocha();
            var columns = plocha.Columns;

            foreach (var devitka in columns)
                Assert.Equal(9, devitka.Policka.Length);
        }
    }
}