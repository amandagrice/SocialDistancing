using UnityEngine;
using System.Collections;
 

public class Floating : MonoBehaviour {

    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.1f;
    public float frequency = 1f;
 
    Vector3 posOffset = new Vector3 ();
    Vector3 tempPos = new Vector3 ();
 
    void Start () {
        posOffset = transform.position;
        if (Random.value > 0.5f) {
    		amplitude = amplitude * -1;
    	}
    }
     
    void Update () {
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
        tempPos = posOffset;
        tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }
}