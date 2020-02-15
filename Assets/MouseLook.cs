using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float speed=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tmpX = Input.GetAxis("Mouse Y")*speed;
        float tmpY = Input.GetAxis("Mouse X")*speed;

        transform.localEulerAngles += new Vector3(-tmpX, tmpY);
    }
}
