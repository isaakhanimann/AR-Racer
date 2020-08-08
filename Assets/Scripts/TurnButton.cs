using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnButton : MonoBehaviour
{
    public Car.Direction turnDirection;
    private bool heldDown;

    void Update()
    {
        if (heldDown)
        {
            Car.instance.Turn(turnDirection);
        }
    }

    public void OnDown()
    {
        heldDown = true;
    }

    public void OnUp()
    {
        heldDown = false;
    }
}
