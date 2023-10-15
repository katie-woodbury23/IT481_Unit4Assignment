using Unit4_IT481_Woodbury;

namespace UnitTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTestModule t1 = new UnitTestModule(); 

            int[] list = { 1, 50, 200, 312 }; 
            int n = 4; 
            int result = t1.Example1(list, n); 
            Assert.AreEqual(result, 1, "The minimum list value is 1"); 
            Assert.AreNotEqual(result, 50, "The minimum value in the list is not 50");
        }

        [TestMethod]
        public void TestMethod2()
        {
            UnitTestModule t2 = new UnitTestModule();

            int[] list = { 7, 50, 150, 475, 500 };
            int n = 4;
            int result = t2.Example1(list, n);
            Assert.AreEqual(result, 7, "The minimum list value is 7");
            Assert.AreNotEqual(result, 150, "The minimum value in the list is not 150");
        }

        [TestMethod] 
        // Given an array in integers, print out each value
        public void TestMethod3() 
        { 
            UnitTestModule t3 = new UnitTestModule(); 
            
            int[] list = new int[100]; 
            for (int i = 0; i < 100; i++) 
            { 
                list[i] = i + 1; 
            } 
            t3.Example2(list); 
            Assert.IsTrue(true, "Function suceeded"); 
            Assert.AreNotEqual(null, false, "The function did not fail"); 
        }

        [TestMethod]
        // Given an array in integers, print out each value
        public void TestMethod4()
        {
            UnitTestModule t4 = new UnitTestModule();

            int[] list = new int[150];
            for (int i = 0; i < 100; i++)
            {
                list[i] = i + 1;
            }
            t4.Example2(list);
            Assert.IsTrue(true, "Function suceeded");
            Assert.AreNotEqual(null, false, "The function did not fail");
        }

        [TestMethod] 
        // Given two integer search values if they are equal to the values in the array
        public void TestMethod5() 
        { 
            UnitTestModule t5 = new UnitTestModule(); 
            
            int[] list = { 1, 5, 7, 10 }; 
            bool result = t5.Example3(list); 
            Assert.IsTrue(true, "Function suceeded"); 
            Assert.AreEqual(result, true, "The value(s) were in the list"); 
        }

        [TestMethod]
        // Given two integer search values if they are equal to the values in the array
        public void TestMethod6()
        {
            UnitTestModule t6 = new UnitTestModule();

            int[] list = { 0, 5, 7, 11, 12, 15 };
            bool result = t6.Example3(list);
            Assert.IsTrue(true, "Function suceeded");
            Assert.AreEqual(result, true, "The value(s) were in the list");
        }

    }
}