using AdaperApp.UI.Business.Abstract;
using AdaperApp.UI.Business.Abstract.XBank;
using AdaperApp.UI.Models;

namespace AdaperApp.UI.Concrete.XBank
{
    public class XBankMessageManager : BankMessage , IXBankMessageService //Adaptee
    {
        public override string Message { get => "This is X bank message."; }

        public BankMessage CreateBankMessage()
        {
            Console.WriteLine(Message);
            XBankSpecialMethod();
            return new BankMessage { Message = this.Message };
        }

        public void XBankSpecialMethod()
        {
            Console.WriteLine("XBankSpecialMethod is executed.");
        }
    }
}
