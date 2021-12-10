using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedScript : MonoBehaviour
{
    public Car car;
    Text txtSpeed;

    // Start is called before the first frame update
    void Start()
    {
        txtSpeed = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txtSpeed.text = "Speed: " + car.GetSpeed().ToString("0.00") + "Km/h";
    }
}
