using System;
using System.Collections.Generic;

namespace Debuggigng
{
    class Program
    {
        static void Main(string[] args)
        {
            var friends = new List<string> { "Frank", "Raag", "Raagdsf", "Rfffaadg", "Seraasaag", "Raagcf", "Rag", "Rg", "Raersdaqewag" };
            var partyFriends = GetPartyFriends(friends, 3);

            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }
        }
        /// <summary>
        /// This is for soteset leeter word name
        /// </summary>
        /// <param name="list"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();
            while(partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }
        // for shortest lenght name
        public static string GetPartyFriend(List<string> list)
        {
            string shoetestName = list[0];
            for (var i = 0; i < list.Count; i++){
                if(list[i].Length < shoetestName.Length)
                    //if (list[i].Length > longestName.Length)
                    {
                    shoetestName = list[i];
                }
            }
            return shoetestName;
        }
    }
}
