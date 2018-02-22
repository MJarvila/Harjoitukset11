using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj11Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            MailBook mailbook = new MailBook();
            mailbook.Friends.ForEach(x => Console.WriteLine(x.Name));
            Friend friend = new Friend("Paavo Kekkonen", "kekkonen@miesitse.fi");
            mailbook.AddFriend(friend);
        }
    }
}
