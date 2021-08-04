using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    ///<summary>Causes coin to rotate on screen</summary>
    void Update()
    {
        gameObject.transform.Rotate(45 * Time.deltaTime, 0, 0);
    }
}
