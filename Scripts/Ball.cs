using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    bool isPlaying = false;

    void Update()
    {
        StartGameOnTap();  
    }

    public void StartGameOnTap()
    {
        if (!isPlaying)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -3.2f);
                isPlaying = true;
            }
        }
    }
}
