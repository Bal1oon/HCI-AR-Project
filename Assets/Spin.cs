using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float freq;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, freq * Time.deltaTime, 0f, Space.Self);
    }
}
