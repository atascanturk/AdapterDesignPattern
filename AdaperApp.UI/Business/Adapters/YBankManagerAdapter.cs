using AdaperApp.UI.Business.Abstract;
using AdaperApp.UI.Business.Abstract.YBank;
using AdaperApp.UI.Concrete.YBank;
using AdaperApp.UI.Models;

namespace AdaperApp.UI.Business.Adapters
{
    public class YBankManagerAdapter : IYBankService // Adapter
    {
        public void SendToBank()
        {
            YBankMessageManager yBankMessageManager = new YBankMessageManager();

            var message = yBankMessageManager.CreateBankMessage();

            Console.WriteLine($"Message sent to YBank.");
        }
    }
}
