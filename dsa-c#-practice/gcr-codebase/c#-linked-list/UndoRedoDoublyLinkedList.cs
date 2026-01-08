using System;

class StateNode
{
    public string Text;
    public StateNode Prev, Next;
}

class Editor
{
    StateNode current;

    public void Add(string text)
    {
        StateNode n = new StateNode { Text = text };
        if (current != null) current.Next = n;
        n.Prev = current;
        current = n;
    }

    public void Undo() { if (current?.Prev != null) current = current.Prev; }
    public void Redo() { if (current?.Next != null) current = current.Next; }
}
