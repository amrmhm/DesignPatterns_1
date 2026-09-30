using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Iterator;

public class BrowserHistory
{
    // private List<string> Urls = new List<string>();
    private string[] Urls = new string[10];
    private int count;

    public void push (string url)
    {
        //Urls.Add (url);


        // Urls.Append(url);
        //Or
        Urls[count++] = url;
    }

    public string pop()
    {
        //var lastIndex = Urls.Count - 1;
        //var lastUrls = Urls[lastIndex];
        //Urls.RemoveAt(lastIndex);

        //return lastUrls;
        return Urls[--count];
    }

      public Iterator createList()
    {
        //return new ListIterator(this);
        return new ArrayIterator(this);
    }

    //public class ListIterator : Iterator
    //{
    //    private int index;
    //    private readonly BrowserHistory History;
    //    public ListIterator(BrowserHistory history)
    //    {
    //        History = history;
    //    }


    //    public string current()
    //    {
    //        return History.Urls[index];
    //    }

    //    public bool hasNext()
    //    {
    //        return (index < History.Urls.Count);
    //    }

    //    public void next()
    //    {
    //        index++;
    //    }
    //}
    public class ArrayIterator : Iterator
    {
        private BrowserHistory History;
        private int count;

        public ArrayIterator(BrowserHistory history)
        {
            History = history;
        }

        public string current()
        {
          return History.Urls[count];
        }

        public bool hasNext()
        {
            return (count < History.Urls.Length);


        }

        public void next()
        {
            count++;
        }
    }
}
