using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    [SerializeField] float timer;
    [SerializeField] int day;
    void Start()
    {
        timer = 0;
        day = 0;
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if(timer > 5f)
        {
            day += 1;
            timer = 0;
        }
    }
}
