using NUnit.Framework;
using System;
using System.Threading;

namespace AutoTestai
{
    public class SimpleTests
    {
        [Test]
        public static void TestIf4IsEven()
        {
            int leftover = 4 % 2;
            //Assert.AreEqual(0, leftover, "4 is not even");
            Assert.IsTrue(0 == leftover, "4 is not even");
        }

        [Test]
        public static void TestNowIs20Hour()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(20, currentTime.Hour, "Dabar nera 20:00 val");
        }

        [Test]
        public static void ArDalinasi995Is3()
        {
            Assert.AreEqual(0, 995 % 3, "995 canot be divided by 3");          
        }

        [Test]
        public static void IsItWednesday()
        {
            DateTime currentTime = DateTime.Today;
            Assert.AreEqual(DayOfWeek.Wednesday, currentTime.DayOfWeek);
        }

        [Test]
        public static void Wait5Seconds()
        {
            Thread.Sleep(5000); //Lauks 5 sec
            Assert.Pass();
        }

        [Test]
        public static void KiekYraLyginiuTarp1ir10()
        {
            int kiek = 0;
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    kiek++;
                }
            }

            Assert.AreEqual(4, kiek);
    
        }
    }
}
