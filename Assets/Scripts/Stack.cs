using System;
using System.Collections.Generic;
using UnityEngine;

public class Stack
{
	private List<int> newStack;

    public void CreateStack(int capacity)
	{
			if (capacity <= 0)
			{
				Debug.LogError("Stack capacity can't be less than 1 ");
				return;
			}
			newStack = new List<int>(capacity);
	}

	public void Push(int _value)
	{
		newStack.Add(_value);
	}

	public int Pop()
	{
		int element = newStack[newStack.Count - 1];
		newStack.RemoveAt(newStack.Count -1);
		Debug.Log(element);
		return element;
	}

	public int Peek()
	{
		int element = newStack[newStack.Count - 1];
		Debug.Log(element);
		return element;
	}

	public bool IsEmpty()
	{
		Debug.Log(newStack.Count == 0);
		return newStack.Count == 0;			
    }

    public void PrintStackContent()
    {
        for (int i = 0; i < newStack.Count; i++)
        {
            Debug.Log(newStack[i]);
        }
    }
}
