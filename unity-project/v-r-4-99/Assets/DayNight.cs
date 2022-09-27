using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    public Transform sun;
    public float startTime = 120f;
    public float daySpeed = 0.5f;
    public float nightSpeed = 10f;
    public float dayStart = 0f;
    public float nightStart = 200f;

    private float r = 0;

    // Start is called before the first frame update
    void Start()
    {
      r = startTime;
      sun.eulerAngles = new Vector3(r, -30, 0);
    }

    // Update is called once per frame
    void Update()
    {

       Vector3 euler = sun.eulerAngles;
       if (euler.x > dayStart && euler.x < nightStart)
       {
         r += daySpeed;
       }
       else
       {
         r += nightSpeed;
       }
       sun.eulerAngles = new Vector3(r, -30, 0);
    }
}
