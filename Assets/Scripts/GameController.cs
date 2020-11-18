using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
    public Power power;
    public GameObject wall;

    private void OnEnable()
    {
        Player.onGameControllerUpdated += GameControllerEvent;
        Power.onPowerUpdated += PowerEvent;
    }

    private void OnDisable()
    {
        Player.onGameControllerUpdated -= GameControllerEvent;
        Power.onPowerUpdated -= PowerEvent;
    }

    public void GameControllerEvent()
    {
        Rigidbody2D body = wall.GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(0, 0.5f);
        Destroy(wall, 5);
    }

    public void PowerEvent()
    {
        this.player.gameObject.GetComponent<SpriteRenderer>().color = Color.red;

        GameObject donut = GameObject.Find("Donut");
        if (donut != null)
            donut.GetComponent<SpriteRenderer>().color = Color.black;
    }
}
