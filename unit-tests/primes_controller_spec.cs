using api.Controllers;
using Xunit;

namespace IntegrationTests
{
    public class primes_controller_spec
    {
        [Fact]
        public void when_passing_prime_number()
        {
            var subject = new PrimesController();
            var result = subject.Get(11);
            Assert.Equal("The number is a prime.", result);
        }

        [Fact]
        public void when_passing_non_prime_number()
        {
            var subject = new PrimesController();
            var result = subject.Get(12);
            Assert.Equal("The number is NOT a prime.", result);
        }
    }
}