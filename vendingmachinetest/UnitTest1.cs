using System;
using Xunit;
using VendingMachineNamespace;
namespace vendingmachinetest
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            VendingMachine v = new VendingMachine();
            Assert.NotNull(v);

        }
    }
}
