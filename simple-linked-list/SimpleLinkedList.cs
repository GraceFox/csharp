using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    public T Value { get; set; }
    public SimpleLinkedList<T> Next;

    public SimpleLinkedList(T value, SimpleLinkedList<T> next = null)
    {
        Value = value;
        Next = next;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        Value = values.First();
        foreach (var value in values.Skip(1).Reverse())
            Add(value);
    }


    public SimpleLinkedList<T> Add(T value)
    {
        Next = new SimpleLinkedList<T>(value, Next);
        return this;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var it = this;
        while  (it != null)
        {
            yield return it.Value;
            it = it.Next;
        } 
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}