using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour , IEnemy
{
    public void MakePlayerLose()
    {
        print("as");
    }
}
