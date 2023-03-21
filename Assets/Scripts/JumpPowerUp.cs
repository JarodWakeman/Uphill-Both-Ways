using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public float increaseJump = 700f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Pickup(collision);

        }
    }

    void Pickup(Collider2D player)
    {
        CharacterController2D stats =  player.GetComponent<CharacterController2D>();
        stats.m_JumpForce += increaseJump;

        Destroy(gameObject);
    }
}
