using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMovement : MonoBehaviour
{
    public Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tr.eulerAngles += new Vector3(1, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            tr.eulerAngles += new Vector3(-1, 0, 0);
        }
    }
}
