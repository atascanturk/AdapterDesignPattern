using AdaperApp.UI.Business.Abstract;
using AdaperApp.UI.Business.Abstract.YBank;
using AdaperApp.UI.Models;

namespace AdaperApp.UI.Concrete.YBank
{
    public class YBankMessageManager : BankMessage, IYBankMessageService //Adaptee
    {
        public override string Message { get => "This is Y bank message."; }

        public BankMessage CreateBankMessage()
        {
            Console.WriteLine(Message);
            YBankSpecialMethod();
            return new BankMessage { Message = this.Message };
        }

        public void YBankSpecialMethod()
        {
            Console.WriteLine("YBankSpecialMethod is executed.");
        }
    }
}
