using System;
using System.Collections.Generic;
using System.Text;

namespace Shopkeep
{
    class Merchant
    {     
        //create all conversation lists
        List<string> _greetings = new List<string>();
        List<string> _goodbyes = new List<string>();
        List<string> _quests = new List<string>();
        List<string> _startShop = new List<string>();
        List<string> _selling = new List<string>();
        List<string> _stopShop = new List<string>();
        List<string> _talk = new List<string>();

        //load strings into the lists

        //load inventory
        Dictionary<string, int> _inventory = new Dictionary<string, int>();

        //load items into inventory


        //Base function
        public void Shopkeeping()
        {
            Greeting();
            Interaction(0);
        }


        //micro functions
        public void Interaction(int value)//0 for first call, 1 for second and beyond, 2 for user misinput
        {
            if(value == 0)
            {
                Console.WriteLine("What can I help you with traveler? (Type shop, quest, talk, or goodbye)\n");
            }
            else if (value == 1)
            {
                Console.WriteLine("What else can I do for you? (Type shop, quest, talk, or goodbye)\n");
            }
            else if (value == 2)
            {
                Console.WriteLine("Huh? Speak clearly friend, my ears aren't what they used to be. (Type shop, quest, talk, or goodbye)\n");
            }

            string _playerResponse = Console.ReadLine();
            _playerResponse = _playerResponse.ToLower();

            if (_playerResponse == "shop")
            {
                Shop();
            }
            else if (_playerResponse == "quest")
            {
                Quest();
            }
            else if (_playerResponse == "talk")
            {
                Talk();
            }
            else if (_playerResponse == "goodbye")
            {
                Goodbye();
            }
            else
            {
                Interaction(2);
            }
        }
        public void Greeting()
        {
            var random = new Random();
            int index = random.Next(_greetings.Count);
            Console.WriteLine(_greetings[index] + "\n");
        }
        public void Goodbye()
        {
            var random = new Random();
            int index = random.Next(_goodbyes.Count);
            Console.WriteLine(_goodbyes[index] + "\n");
        }
        public void Shop()
        {
            var random = new Random();
            int index = random.Next(_startShop.Count);
            Console.WriteLine(_startShop[index] + "\n");

            //displaying inventory
            foreach (KeyValuePair<string, int> item in _inventory)
            {
                Console.WriteLine(item.Value + ": " + item.Key + " gold\n");
            }
            Console.WriteLine("Anything catch your eye? (type item name to purchase or 'no' to exit.\n");

            //buyng stuff
            string _input = Console.ReadLine().ToLower();
            //to be completed
            //figure out how to modify dictionarys in a loop for this


            var random2 = new Random();
            int index2 = random2.Next(_stopShop.Count);
            Console.WriteLine(_stopShop[index2] + "\n");
        }
        public void Quest()
        {

        }
        public void Talk()
        {

        }

    }
}
