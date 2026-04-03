using System;
using System.Collections.Generic;

namespace BridgeLabzTraning.BookBuddy
{
    internal abstract class AbstractBookshelf
    {
        protected List<string> books = new List<string>();

        protected string[] ExportToArray()
        {
            return books.ToArray(); // memory-safe export
        }
    }
}
