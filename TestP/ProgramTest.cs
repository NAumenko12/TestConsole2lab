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
                using (StringReader sr = new StringReader("3\n5\n"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    Program.Main(null);
                }
                string expected = "Введите первое число:\r\nВведите второе число:\r\nМатрица умножения для чисел 3 и 5:\r\n1\t2\t3\t4\t5\t\n2\t4\t6\t8\t10\t\n3\t6\t9\t12\t15\t\n";
                Assert.AreEqual(expected, sw.ToString());
            }

        }
    }
}