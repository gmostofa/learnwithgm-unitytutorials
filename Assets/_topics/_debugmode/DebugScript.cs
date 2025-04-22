using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour
{
    private int holdingInt = 5;
    private float holdingFloat = 10f;

    private string holdingString = "this is string";

    private float changedValue;

    private void Update()
    {
        changedValue += Time.deltaTime;
    }
}
