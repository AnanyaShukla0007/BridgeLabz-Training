using System;
using System.Collections.Generic;

class UserNode
{
    public int Id;
    public string Name;
    public List<int> Friends = new List<int>();
    public UserNode Next;
}
