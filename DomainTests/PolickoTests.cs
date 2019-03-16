using Domain;
using Xunit;

namespace DomainTests
{
    public class PolickoTests
    {
        [Fact]
        public void NewInstance_HasEmptyValue()
        {
            var policko = new Policko();

            Assert.Null(policko.Hodnota);
        }
    }
}