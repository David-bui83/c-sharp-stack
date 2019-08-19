using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist firstOne = Artists.FirstOrDefault();
            System.Console.WriteLine("#########################");
            System.Console.WriteLine("Name " + firstOne.ArtistName);
            System.Console.WriteLine("Age " + firstOne.Age);

            //Who is the youngest artist in our collection of artists?
            List<Artist> youngest = Artists.OrderBy(a => a.Age).ToList();
            
            System.Console.WriteLine("Name " + youngest.First().ArtistName);
            System.Console.WriteLine("Age" + youngest.First().Age);

            // Display all artists with 'William' somewhere in their real name
            List<Artist> williamList = Artists.Where(a => a.RealName.Contains("William")).ToList();
            foreach(var w in williamList)
            {
                System.Console.WriteLine("William in name: " + w.RealName);
            }
            // Display all groups with name less than 8 characters in length.
            List<Group> nameList = Groups.Where(g => g.GroupName.Length < 8).ToList();
            foreach(var name in nameList)
            {
                System.Console.WriteLine("name less than 8 characters: " + name.GroupName);
            }
            //Display the 3 oldest artist from Atlanta
            List<Artist> ageList = Artists.OrderByDescending(a => a.Age).Take(3).ToList();
            foreach(var a in ageList)
            {
                System.Console.WriteLine("Three oldest " + a.Age);
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            List<Group> groupList = Groups.Where(g => g.Members.TrueForAll(m => m.Hometown !=  "New York City")).ToList();
            foreach(var g in groupList)
            {
                System.Console.WriteLine("Not from New York: " + g.GroupName);
            }

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            Group group = Groups.FirstOrDefault(g => g.GroupName =="Wu-Tang Clan");
            foreach(var g in group.Members)
            {
                System.Console.WriteLine("Wu-Tang: " + g.ArtistName);
            }

	        Console.WriteLine(Groups.Count);
        }
    }
}
