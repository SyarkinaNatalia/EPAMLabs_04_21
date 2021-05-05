using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [SetUpFixture]
    class SetupClass
    {
        [OneTimeSetUp]
        public void OneSetUp() 
        { 
        }

        [OneTimeTearDown]
        public void OneTearDown() 
        { 
        }
    }
}
