using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Harj11Teht2
{
    class MailBook
    {
        public readonly List<Friend> Friends;

        public MailBook()
        {
            Friends = new List<Friend>();
            string[] fileData = File.ReadAllLines(@"C:\Users\Akallath\Desktop\Koululaput\Olio-ohjelmointi\Harjoitukset11\Harj11Teht2\tutut.csv");
            Console.WriteLine("Osoitekirjassa on {0} nimeä", fileData.Count());
        }

        public void AddFriend(Friend friend)
        {
            Friends.Add(friend);

            StreamWriter sw = new StreamWriter(@"C:\Users\Akallath\Desktop\Koululaput\Olio-ohjelmointi\Harjoitukset11\Harj11Teht2\tutut.csv");
            foreach (Friend fr in Friends)
            {
                sw.WriteLine(friend.Name + "," + friend.Email);
            }

            sw.Close();
        }

        public void Search(string search)
        {
            List<Friend> searchList = Friends.FindAll(x => x.Name.StartsWith(search));

            foreach (Friend fr in searchList)
            {
                Console.WriteLine(fr.Name + "," + fr.Email);
            }
        }
    }
}
