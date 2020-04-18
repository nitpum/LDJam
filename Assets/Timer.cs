using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    [SerializeField] float updateMin;
    [SerializeField] float minuteTimer;
    [SerializeField] float hrTimer;
    [SerializeField] int day;
    void Start()
    {
        updateMin = 5;
        hrTimer = 0;
        minuteTimer = 0;
        day = 0;
    }
    void FixedUpdate()
    {
        updateMin += Time.deltaTime;
        if(updateMin > 5f)
        {
            minuteTimer += 1;
            updateMin = 0;
            if(minuteTimer > 60)
            {
                hrTimer += 1;
                minuteTimer = 0;
                if(hrTimer > 24)
                {
                    day += 1;
                    hrTimer = 0;
                }
            }
        }
    }
}
