// See https://aka.ms/new-console-template for more information
using AdaperApp.UI.Business.Abstract;
using AdaperApp.UI.Business.Adapters;


IBankService xBankService = new XBankManagerAdapter();
xBankService.SendToBank();



IBankService yBankService = new YBankManagerAdapter();
yBankService.SendToBank();
