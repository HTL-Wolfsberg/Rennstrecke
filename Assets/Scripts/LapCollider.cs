using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCollider : MonoBehaviour
{
    public bool CarHasCollided = false;

    private void OnTriggerEnter(Collider other)
    {
        CarHasCollided = true;
        LapCounter.lapCounter.CarHasCollided();
    }

    public void Reset()
    {
        CarHasCollided = false;
    }
}
