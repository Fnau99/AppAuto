using System.ComponentModel.Design;

namespace TestAuto
{
    [TestClass]//fanno capire a visualstudio che è un progetto di test
    public class UnitTest1
    {
        /// <summary>
        /// Test Auto.Accendi
        /// </summary>
        [TestMethod]
        public void TestTurnOn()
        {
            //declare and initialize object
            prima_app.Auto TestAuto;
            TestAuto = new prima_app.Auto();

            //call object method
            TestAuto.Accendi();

            //check object state: it has to be off
            if (TestAuto.GeneraStato() == "carburante: 0 \nspento\n")
            {
                //ok
            }
            else
            {
                //error
                throw new Exception("");
            }




        }
    }
}