// See https://aka.ms/new-console-template for more information
using System.Collections;

// Console.WriteLine("Hello, World!");
Stack stack = new Stack();
stack.Push(3);
stack.Push(5);
stack.Push(6);
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

public class Stack
{
    private ArrayList elements;

    public Stack()
    {
        this.elements = new ArrayList();
    }

    public void Push(object elem)
    {
        if (elem == null) { 
            throw new InvalidOperationException();
        }
        elements.Add(elem);
    }
     public object Pop()
    {
        var amount = elements.Count;
        if (amount == 0)
        {
            throw new InvalidOperationException();
        }
        object elem = elements[index: amount - 1];
        elements.Remove(elem);
        return elem;
    }

    public void Clear()
    {
        elements.Clear();
    }
}
