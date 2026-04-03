using System;

class ProcessNode
{
    public int Pid, Burst;
    public ProcessNode Next;
}

class RoundRobin
{
    ProcessNode head;

    public void Add(int id, int b)
    {
        ProcessNode n = new ProcessNode { Pid = id, Burst = b };
        if (head == null) { head = n; n.Next = head; return; }
        ProcessNode t = head;
        while (t.Next != head) t = t.Next;
        t.Next = n; n.Next = head;
    }
}
