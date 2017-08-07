using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusktoDawn : MonoBehaviour
{

    public GameObject sun;

    private float dayLength = 0.2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(6.0f * dayLength * Time.deltaTime, 0, 0);
    }
}

