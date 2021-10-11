using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;

    public Vector3 tempPosition;

    void Update()
    {
    //if you want to change keybind write key name instead of "Space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tempPosition = Object1.transform.position;

            Object1.transform.position = Object2.transform.position;

            Object2.transform.position = tempPosition;
        }
    }
}
