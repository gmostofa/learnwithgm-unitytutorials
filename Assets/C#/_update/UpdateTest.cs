using System;
using UnityEngine;

public class UpdateTest : MonoBehaviour
{
    private int totalUpdateCallPerSecond;
    int totalFixedUpdateCallPerSecond;
    int totalLateUpdateCallPerSecond;

    private float updateTimer = 1;
    float fixedUpdateTimer = 1;
    float lateUpdateTimer = 1;

    private void Update()
    {
        totalUpdateCallPerSecond++;
        updateTimer -= Time.deltaTime;

        if (updateTimer <= 0)
        {
            Debug.Log("Update Call per second  :"+totalUpdateCallPerSecond);
            totalUpdateCallPerSecond = 0;
            updateTimer = 1;
        }
    }

    private void FixedUpdate()
    {
        totalFixedUpdateCallPerSecond++;
        fixedUpdateTimer -= Time.deltaTime;
        if (fixedUpdateTimer <= 0)
        {
            Debug.Log("Fixed Update Call per second  :"+totalFixedUpdateCallPerSecond);
            totalFixedUpdateCallPerSecond = 0;
            fixedUpdateTimer = 1;
        }
    }

    private void LateUpdate()
    {
        totalLateUpdateCallPerSecond++;
        lateUpdateTimer -= Time.deltaTime;
        if (lateUpdateTimer <= 0)
        {
            Debug.Log("Late Update Call per second  :"+totalLateUpdateCallPerSecond);
            totalLateUpdateCallPerSecond = 0;
            lateUpdateTimer = 1;
        }
    }
}
