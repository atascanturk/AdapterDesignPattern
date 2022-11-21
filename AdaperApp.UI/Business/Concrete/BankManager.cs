using AdaperApp.UI.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaperApp.UI.Business.Concrete
{
    public class BankManager : IBankService
    {
        IBankMessageService _bankMessageService;

        public BankManager(IBankMessageService bankMessageService)
        {
            _bankMessageService = bankMessageService;
        }

        public void SendToBank()
        {
           var  message = _bankMessageService.CreateBankMessage();
        }
    }
}
