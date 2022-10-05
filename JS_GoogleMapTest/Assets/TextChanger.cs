using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public GPSManager GPS;
    public GameObject Camera;

    public TextMeshProUGUI Lat;
    public TextMeshProUGUI Long;
    public TextMeshProUGUI High;
    public TextMeshProUGUI Err;
    public TextMeshProUGUI Pos;


private void Update() 
{
    
    Lat.text = "Lat : " + GPS.Lat.ToString();
    Long.text = "Long : " + GPS.Long.ToString();
    High.text = "High : " + GPS.High.ToString();
    Err.text = "Err : " + GPS.ErrText;
    Pos.text = $"({Camera.transform.position.x} / {Camera.transform.position.y} / {Camera.transform.position.z})";
}




}
