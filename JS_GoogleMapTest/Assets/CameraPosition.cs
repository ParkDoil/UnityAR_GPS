using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    public GPSManager GPS;

    void Update()
    {
        transform.position = new Vector3(0f, 1.7f, 0f);
    }
}
