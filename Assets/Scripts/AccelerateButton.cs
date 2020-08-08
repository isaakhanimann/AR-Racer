using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateButton : MonoBehaviour
{
    public void OnDown()
    {
        Car.instance.shouldAccelerate = true;
    }

    public void OnUp()
    {
        Car.instance.shouldAccelerate = false;
    }
}
