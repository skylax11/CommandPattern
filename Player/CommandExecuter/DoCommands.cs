using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoCommands : MonoBehaviour,ICommand
{
    private Controller m_Controller;
    private Vector2 direction;

    public DoCommands(Vector2 direction,Controller m_Controller)
    {
        this.m_Controller = m_Controller;
        this.direction = direction;
    }
    public void Execute()
    {
        m_Controller.Move(direction);
    }
    public void Undo()
    {
        m_Controller.Move(-direction);
    }
}
