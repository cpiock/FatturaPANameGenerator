using Microsoft.VisualStudio.TestTools.UnitTesting;
using FatturaPANameGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatturaPANameGenerator.Tests
{
    [TestClass()]
    public class SequenceGeneratorTests
    {
        SequenceGenerator generator;
       [TestInitialize]
        public void SetUp()
        {
            generator = new SequenceGenerator();
        }

        [TestCleanup]
        public void TearDown()
        {
            generator = null;
        }

        [TestMethod()]
        public void NextCodeTestA00001()
        {
            string oldCode = "A00001";
            

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "A00002");
        }

        [TestMethod()]
        public void NextCodeTest000001()
        {
            string oldCode = "000001";


            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "000002");
        }
        [TestMethod()]
        public void NextCodeTest999999()
        {
            string oldCode = "999999";


            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "A00000");
        }

        [TestMethod()]
        public void NextCodeTestA00009()
        {
            string oldCode = "A00009";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "A00010");
        }
        [TestMethod()]
        public void NextCodeTestA12999()
        {
            string oldCode = "A12999";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "A13000");
        }
        [TestMethod()]
        public void NextCodeTestA19999()
        {
            string oldCode = "A19999";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "A20000");
        }
        [TestMethod()]
        public void NextCodeTestA99999()
        {
            string oldCode = "A99999";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "B00000");
        }

        [TestMethod()]
        public void NextCodeTestZZ9999()
        {
            string oldCode = "ZZ9999";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "ZZA000");
        }

        [TestMethod()]
        public void NextCodeTestZ99999()
        {
            string oldCode = "Z99999";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "ZA0000");
        }
        [TestMethod()]
        public void NextCodeTestZ99123()
        {
            string oldCode = "Z99123";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "Z99124");
        }

        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NextCodeTestZZZZZZ()
        {
            string oldCode = "ZZZZZZ";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);
           
        }
        [TestMethod()]
        public void NextCodeTestZBR234()
        {
            string oldCode = "ZBR234";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "ZBR235");
        }
        [TestMethod()]
        public void NextCodeTestZBR934()
        {
            string oldCode = "ZBR934";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "ZBR935");
        }
        [TestMethod()]
        public void NextCodeTestZBR999()
        {
            string oldCode = "ZBR999";
            SequenceGenerator generator = new SequenceGenerator();

            string newCode = generator.NextCode(oldCode);

            Assert.AreEqual(newCode, "ZBS000");
        }
    }
}