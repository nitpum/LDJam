using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpeed : MonoBehaviour
{

    const float normalScale = 1.0f;
    const float speedUpScale = 10.0f;

    public void SetSpeedUp()
    {
        Time.timeScale = speedUpScale;
    }

    public void SetSpeedNormal()
    {
        Time.timeScale = normalScale;
    }

}
