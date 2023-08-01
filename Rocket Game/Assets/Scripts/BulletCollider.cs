using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BulletCollider : MonoBehaviour
{
    public static event Action PlayerGetsScore;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Meteor")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            if (PlayerGetsScore != null)
            {
                PlayerGetsScore();
            }
            
            
        }
    }
  }
