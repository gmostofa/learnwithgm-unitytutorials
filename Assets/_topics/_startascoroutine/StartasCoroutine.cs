using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartasCoroutine : MonoBehaviour
{
    private IEnumerator Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Countdown "+i);
            yield return new WaitForSeconds(1f);
        }

        Debug.Log("Done the Loop!");
    }
}
