using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAll : MonoBehaviour
{
    public Transform[] squares;
    public float[] speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi I'm RotateAll.cs file");
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < squares.Length; i++)
        {
            squares[i].rotation = Quaternion.Euler(new Vector3(0, Time.time * speed[i], 0));
        }


    }
}
