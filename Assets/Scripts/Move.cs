using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals
{
    public static float BALL_SPEED = 5f;
}
public class Move : MonoBehaviour
{
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = Vector2.one * Globals.BALL_SPEED;
    }
    void Update()
    {
        
    }
}

