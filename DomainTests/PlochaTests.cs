using System.Collections.Generic;
using Domain;
using Xunit;

namespace DomainTests
{
    public class PlochaTest
    {
        public static IEnumerable<object[]> GetElements()
        {
            var plocha = new Plocha();
            yield return plocha.Rows;
            yield return plocha.Columns;
        }

        [Theory]
        [MemberData(nameof(GetElements))]
        public void CreatingNew_Creates9Elements(params object[] elements)
        {
            Assert.Equal(9, elements.Length);
        }

        [Fact]
        public void CreatingNew_AllRowsAreInitialized()
        {
            var plocha = new Plocha();
            var rows = plocha.Rows;
            foreach (var row in rows)
                Assert.NotNull(row);
        }

        [Fact]
        public void CreatingNew_Creates9Columns()
        {
            var plocha = new Plocha();
            var columns = plocha.Columns;
            Assert.Equal(9, columns.Length);
        }
    }
}