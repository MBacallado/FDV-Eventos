using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{
    public delegate void PowerUpdated();
    public static event PowerUpdated onPowerUpdated;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null)
        {
            this.PowerUpdatedEvent();
            Destroy(this.gameObject);
        }
            
    }

    private void PowerUpdatedEvent()
    {
        if (onPowerUpdated != null)
        {
            onPowerUpdated();
        }
    }
}
