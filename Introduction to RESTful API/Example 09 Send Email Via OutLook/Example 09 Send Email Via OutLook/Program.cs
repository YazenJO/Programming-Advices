using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Example_09_Send_Email_Via_OutLook
{
    internal class Program
    {
        //using ms outlook to send email

        static void Main(string[] args)
        {
            Outlook.Application outlookApp = new Outlook.Application();
            Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = "Test Subject";
            mailItem.To = "yazenbilal60@hotmail.com";
            mailItem.Body = "Test Body";
            mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
            ((Outlook._MailItem)mailItem).Send();
            Console.WriteLine("Email Sent Successfully");
            Console.ReadLine();

        }
    }
}
