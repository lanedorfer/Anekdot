using System;
using System.Collections;
using System.Collections.Generic;
using PlayerSpace;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collison)
    {
        if (collison.gameObject == Player.Instance.gameObject)
        {
            Player.Instance.GetDamage();
        }
    }
}
