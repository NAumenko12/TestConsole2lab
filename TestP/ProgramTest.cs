using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestP
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestConsoleInput()
        {
            using (StringWriter sw = new StringWriter())
            {
                using (StringReader sr = new StringReader("3\n4\n"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    Program.Main(null);
                }
                string expected =  "Введите значение x: \r\nВведите значение y: \r\nМатрица умножения:\r\n1 2 3 \r\n2 4 6 \r\n3 6 9 \r\n4 8 12 \r\n";
                Assert.AreEqual(expected, sw.ToString());
            }

        }
         [TestMethod]
        public void TestInvalidInputString()
        {
            using (StringWriter sw = new StringWriter())
            {
                using (StringReader sr = new StringReader("abc\n4\n"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    Program.Main(null);
                }
                string expected = "Введено неверное значение для числа 1";
                Assert.AreEqual(expected, sw.ToString());
            }

        }
        [TestMethod]
        public void TestInvalidInputNegativeNumber()
        {
            using (StringWriter sw = new StringWriter())
            {
                using (StringReader sr = new StringReader("-3\n4\n"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    Program.Main(null);
                }
                string expected = "Введено неверное значение для числа 1";
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}
