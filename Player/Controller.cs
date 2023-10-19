using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent<IEnemy>(out var enemy))
        {
            enemy.MakePlayerLose();
        }
    }
    public void Move(Vector2 direction)
    {
        print("sa");
        transform.Translate(direction);
    }
}
