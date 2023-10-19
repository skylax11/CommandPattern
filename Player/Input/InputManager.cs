using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public void CommandMove(Vector2 direction)
    {
        ICommand command = new DoCommands(direction,GetComponent<Controller>());
        Command.DoCommand(command);
    }
    public void OnMove(InputValue val)
    {
        Vector2 dir = val.Get<Vector2>();
        if (dir == Vector2.zero)
            return;

        dir = val.Get<Vector2>();
        CommandMove(dir);
    }
    public void OnUndo()
    {
        Command.Undo();
    }
    public void OnRedo()
    {
        Command.Redo();
    }
}
