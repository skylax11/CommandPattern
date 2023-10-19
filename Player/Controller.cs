using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public void Move(Vector2 direction)
    {
        transform.Translate(direction);
    }
}
