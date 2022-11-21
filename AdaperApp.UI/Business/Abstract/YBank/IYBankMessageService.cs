using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaperApp.UI.Business.Abstract.YBank
{
    public interface IYBankMessageService : IBankMessageService
    {
        void YBankSpecialMethod();
    }
}
