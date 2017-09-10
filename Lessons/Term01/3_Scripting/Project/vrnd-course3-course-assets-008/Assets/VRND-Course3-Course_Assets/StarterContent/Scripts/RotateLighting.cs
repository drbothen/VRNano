using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLighting : MonoBehaviour
{

    public GameObject directionalLight;

    private float startTime = 0f;
    private bool isPressed = false;

	// Use this for initialization
	void Start ()
	{
//         GvrViewer.Instance.OnTrigger += ActivateRotation;
    }
	
	// Update is called once per frame
	void Update () {
//		directionalLight.transform.Rotate(0f, Time.deltaTime, 0f);

        Quaternion startRotation = Quaternion.Euler(50f, 30f, 0f);
        Quaternion endRotation = startRotation * Quaternion.Euler(0f, 180f, 0f);

	    if (isPressed == true)
	    {
            directionalLight.transform.rotation = Quaternion.Slerp(startRotation, endRotation, startTime / 60f);
	        startTime += Time.deltaTime;
	    }
        
	}

    public void ActivateRotation()
    {
        isPressed = true;
    }

}
