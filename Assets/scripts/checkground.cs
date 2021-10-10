using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkground : MonoBehaviour
{
    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerController>();

    }

    void OnCollisionStay2D(Collision2D  col)
    {
        if (Col.gameObject.tag == "Ground")
        {
            player.grounded = true;
        }

    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (Col.gameObject.tag == "Ground")
        {
            player.grounded = false;
        }
    }
 }
