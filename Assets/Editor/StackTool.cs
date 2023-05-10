using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using JetBrains.Annotations;
using System;

public class StackTool : EditorWindow
{
    [MenuItem("Window/MyStackTool")]
    public static void ShowWindow()
    {
        GetWindow<StackTool>("Stack Tool");
    }

    private Stack stack = new Stack();
    private string textCapacity = string.Empty;
    private string textPush = string.Empty;

    private void OnGUI()
    {
        GUILayout.BeginHorizontal();
        GUILayout.Label("Capacity");
        textCapacity = GUILayout.TextField(textCapacity);
        GUILayout.EndHorizontal();

        
        if (GUILayout.Button("Create Stack") && int.TryParse(textCapacity, out int capacity))
        {           
            stack.CreateStack(capacity);
        }

        

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Pop"))
        {
            stack.Pop();
        }

        if (GUILayout.Button("Push") && int.TryParse(textPush, out int element))
        {
            stack.Push(element);
        }

        textPush = GUILayout.TextField(textPush);

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Peek"))
        {
            stack.Peek();
        }
        if (GUILayout.Button("IsEmpty"))
        {
            stack.IsEmpty();
        }

        GUILayout.EndHorizontal();
  
        if (GUILayout.Button("Print"))
        {
            stack.PrintStackContent();
        }    
    }
}
