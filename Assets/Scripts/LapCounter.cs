using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCounter : MonoBehaviour
{
    public LapCollider[] LapColliders;
    public static LapCounter lapCounter;
    public Text txtLapTimer;
    private float timer = 0;

    void Start()
    {
        lapCounter = this;
    }

    private void Update()
    {
        timer += Time.deltaTime;
    }

    public void CarHasCollided()
    {
        for(int i = 0; i < LapColliders.Length; i++)
        {
            if(!LapColliders[i].CarHasCollided)
            {
                return;
            }
        }

        txtLapTimer.text = "Time: " + timer.ToString("0.00");
        timer = 0;

        for (int i = 0; i < LapColliders.Length; i++)
        {
            LapColliders[i].Reset();
        }
    }
}
