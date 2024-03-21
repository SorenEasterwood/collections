using System;
using System.Net.NetworkInformation;
namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Queue<string> books = new Queue<string>();                            Queue<T>

            books.Enqueue("The Last Wish");
            books.Enqueue("Sword of Destiney");
            books.Enqueue("Blood of Elves");
            books.Enqueue("Time of Contempt");
            books.Enqueue("Baptism of Fire");

            string bookItem = "Sword of Destiney";
            if (books.Contains(bookItem))
                Console.WriteLine("Queue contains Sword of Destiney");
            else
                Console.WriteLine("Queue does not contain Sword of Destiney");

            books.Dequeue();

            Console.WriteLine(books.Count);

            foreach(string b in books)
            {
                Console.WriteLine(b);
            }

            PriorityQueue<string, int> toDo = new PriorityQueue<string, int>();                     PriorityQueue<T>

            toDo.Enqueue("Brush Teeth", 4);
            toDo.Enqueue("Shower", 3);
            toDo.Enqueue("Breakfast", 2);
            toDo.Enqueue("Dress", 1);
            toDo.Enqueue("Start Car", 5);


            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(toDo.Peek());
                toDo.Dequeue();
            }

            Stack<string> games = new Stack<string>();                           Stack<T>

            games.Push("Red Dead Redemption 2");
            games.Push("Witcher 3");
            games.Push("Baldurs Gate 3");
            games.Push("Resident Evil 4");
            games.Push("God of War");

            if (games.Contains("Witcher 3")) 
            {
                Console.WriteLine("Stack contains Witcher 3");
            }

            games.Pop();
            Console.WriteLine(games.Count());

            foreach (var game in games) 
            {
                Console.WriteLine(game);
            }

            string[] movies = { "Spiderman 2", "Forrest Gump", "The Shawshank Redemption", "Oppenheimer", "Godzilla minus one"};             LinkedList<T>
            LinkedList<string> moviesList = new LinkedList<string>(movies);

            Console.WriteLine(moviesList.First());
            Console.WriteLine(moviesList.Last());

            LinkedListNode<string> middleNode = moviesList.Find("Forrest Gump");
            moviesList.AddAfter(middleNode, "John Wick");

            moviesList.RemoveFirst();
            Console.WriteLine(moviesList.Count);   

            foreach (string item in moviesList) 
            {
                Console.WriteLine(item);
            }

            Dictionary<string, string> codeNames = new Dictionary<string, string>();                                 Dictionary<TKey, TValue>

            codeNames.Add("Gomer Pile", "Leonard");
            codeNames.Add("Joker", "James");
            codeNames.Add("Snowball", "Brown");
            codeNames.Add("Cowboy", "Robert");
            codeNames.Add("Sergeant", "Hartman");

            foreach (string name in codeNames.Keys) 
            {
                Console.WriteLine(name);
            }
            foreach (string name in codeNames.Values) 
            {
                Console.WriteLine(name);
            }
            foreach(KeyValuePair<string, string> kvp in codeNames)
            {
                Console.WriteLine(kvp.Key + ", " + kvp.Value);
            }

            codeNames.Remove("Gomer Pile");
            Console.WriteLine(codeNames.Count);

            SortedList<int, string> shows = new SortedList<int, string>();                        SortedList<TKey, TValue>

            shows.Add(1, "Breaking Bad");
            shows.Add(2, "Vinland Saga");
            shows.Add(3, "Deathnote");
            shows.Add(4, "Avatar the Last Airbender");
            shows.Add(5, "Blue Eye Samurai");

            int newKey = 0;

            while (true)
            {
                
                Console.WriteLine("Enter in a new key: ");
                newKey = int.Parse(Console.ReadLine());

                if (shows.ContainsKey(newKey))
                {
                    Console.WriteLine("The Key you entered already exists.");
                }
                else 
                {
                    break;
                }
            }
            Console.WriteLine("Enter in a new value");
            string newValue = Console.ReadLine();

            shows.Add(newKey, newValue);

            shows.Remove(3);

            foreach(KeyValuePair<int, string> kvp in shows)
            {
                Console.WriteLine(kvp.Key + ", " + kvp.Value);
            }

            HashSet<string> heros = new HashSet<string>();                   HashSet<T>
            heros.Add("Cloud");
            heros.Add("Tifa");
            heros.Add("Barret");
            heros.Add("Aerith");
            heros.Add("Red XIII");

            HashSet<string> antagonists = new HashSet<string>();
            antagonists.Add("Sephiroth");
            antagonists.Add("Rufus");
            antagonists.Add("Hojo");
            antagonists.Add("Heidegger");
            antagonists.Add("Shina");

            HashSet<string> side = new HashSet<string>();
            side.Add("Vincent");
            side.Add("Aerith");
            side.Add("Hojo");
            side.Add("Marlene");
            side.Add("Chadley");

            heros.UnionWith(antagonists);
            foreach (string h in heros) 
            {
                Console.WriteLine(h);
            }
            Console.WriteLine();

            HashSet<string> all = new HashSet<string>();
            all.UnionWith(heros.Intersect(side));
            foreach (string h in all)
            {
                Console.WriteLine(h);
            }

            List<string> cards = new List<string>();                      List<T>

            cards.Add("RTX 3060 TI");
            cards.Add("RX 7900 XTX");
            cards.Add("RTX 4090");
            cards.Add("GTX 1080 TI");
            cards.Add("RX 5600 XT");

            cards.AddRange(new string[] { "RTX 4070 TI", "RX 7800 XT", "RTX 3080" });

            cards.Sort();

            foreach (string card in cards)
            {
                Console.WriteLine(card);
            }

            cards.Remove("RTX 4070 TI");

            cards.Reverse();

            foreach (string card in cards)
            { Console.WriteLine(card); }*/
        }
    }
}
