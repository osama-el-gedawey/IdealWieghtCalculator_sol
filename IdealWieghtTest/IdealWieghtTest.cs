using IdealWieghtCalculator;

namespace IdealWieghtTest
{
    [TestClass]
    public class IdealWieghtTest
    {
        [TestMethod]
        public void IdealWieghtcaseMale_Height_170_Gender_M_return_65()
        {
            IdealWieght caseM = new IdealWieght() { Gender = 'm', Height = 170 };
            double Actual = caseM.calculate();
            double Expected = 65;
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void IdealWieghtcaseFemale_Height_176_Gender_f_return_63()
        {
            IdealWieght caseF = new IdealWieght() { Gender = 'f', Height = 176 };
            double Actual = caseF.calculate();
            double Expected = 63;
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void IdealWieghtcaseDefualt_Gender_k_return_0()
        {
            IdealWieght caseDefualt = new IdealWieght() { Gender = 'k' };
            double Actual = caseDefualt.calculate();
            double Expected = 0;
            Assert.AreEqual(Expected, Actual);
        }
    }
}