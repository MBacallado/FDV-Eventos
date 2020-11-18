using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void GameControllerUpdated();
    public static event GameControllerUpdated onGameControllerUpdated;

    private List<GameObject> objects;
    // Start is called before the first frame update
    void Start()
    {
        objects = new List<GameObject>();
    }

    public void AddNewObject(GameObject newObject)
    {
        this.objects.Add(newObject);
        this.GameControllerUpdatedEvent();
    }

    private void GameControllerUpdatedEvent()
    {
        if (onGameControllerUpdated != null)
        {
            onGameControllerUpdated();
        }
    }
}
