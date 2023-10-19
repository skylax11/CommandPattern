using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Command 
{   
    public static Stack<ICommand> undo = new Stack<ICommand>();
    public static Stack<ICommand> redo = new Stack<ICommand>();

    public static void DoCommand(ICommand command)
    {
        command.Execute();
        undo.Push(command);
        redo.Clear();
    }
    public static void Undo()
    {
        if (undo.Count > 0)
        {
            ICommand UndoCommand = undo.Pop();
            redo.Push(UndoCommand);
            UndoCommand.Undo();
        }
    }
    public static void Redo()
    {
        if (redo.Count > 0)
        {
            ICommand RedoCommand = redo.Pop();
            undo.Push(RedoCommand);
            RedoCommand.Execute();
        }
    }
}
