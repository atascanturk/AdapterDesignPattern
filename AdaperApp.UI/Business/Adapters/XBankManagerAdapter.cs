using AdaperApp.UI.Business.Abstract.XBank;
using AdaperApp.UI.Concrete.XBank;
using AdaperApp.UI.Models;

namespace AdaperApp.UI.Business.Adapters
{
    public class XBankManagerAdapter : IXBankService // Adapter
    {   
        public void SendToBank()
        {
            XBankMessageManager bankMessageManager = new XBankMessageManager();

          var message = bankMessageManager.CreateBankMessage();

            Console.WriteLine($"Message sent to XBank.");
        }
    }
}
