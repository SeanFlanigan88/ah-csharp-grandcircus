using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _20210819
{

    public class CalendarEvent
    {
        public string ID
        {
            get
            {
                return Start.ToString("yyyyMMddHH");
            }
        }

        public string Title { get; set; }
        public DateTime Start { get; set; }
        public int HoursLong { get; set; }
    }

    public class MyCalendar : KeyedCollection<string, CalendarEvent>
    {
        protected override string GetKeyForItem(CalendarEvent myEvent)
        {
            return myEvent.ID;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // WorkingWithLinkedLists();

            //WorkingWithSortedDictionaries();

            WorkingWithKeyedCollections();

        }

        #region Collections | LinkedList<T>

        public static void WorkingWithLinkedLists()
        {
            LinkedList<string> myLinkedList = new LinkedList<string>();

            LinkedListNode<string> FirstNode = new LinkedListNode<string>("First Node In The Collection");
            LinkedListNode<string> SecondNode = new LinkedListNode<string>("Second Node In The Collection");
            LinkedListNode<string> ThirdNode = new LinkedListNode<string>("Third Node In The Collection");

            myLinkedList.AddFirst(FirstNode);
            
            myLinkedList.AddAfter(FirstNode, SecondNode);

            myLinkedList.AddAfter(SecondNode, ThirdNode);

            // Console.WriteLine(FirstNode.Next?.Value);

            Console.WriteLine(myLinkedList.Count);

            var node = myLinkedList.First;
            while(true)
            {
                Console.WriteLine(node?.Value);
                if (node.Next == null)
                {
                    break;
                }
                else
                {
                    node = node.Next;
                }
            }

        }

        #endregion

        #region Collections | SortedDictionary<TKey, TValue>

        public static void WorkingWithSortedDictionaries()
        {
            SortedDictionary<string, string> openProgram = new SortedDictionary<string, string>();
            openProgram.Add("new text file", "notepad.exe");
            var program = openProgram["new text file"];
        }

        #endregion

        #region Collection | KeyedCollection (ObjectModel Collection)

        public static void WorkingWithKeyedCollections()
        {
            var calendarDictionary = new Dictionary<string, CalendarEvent>();


            var myNewAppointment = new CalendarEvent();
            myNewAppointment.Title = "My New Appointment";
            myNewAppointment.Start = new DateTime(2021, 8, 23, 12, 0, 0);
            myNewAppointment.HoursLong = 1;

            var myCalendar = new MyCalendar();
            myCalendar.Add(myNewAppointment);

            CalendarEvent nextAppointment = myCalendar["2021082312"];
            Console.WriteLine(nextAppointment.Title);
        }

        #endregion
    }
}
