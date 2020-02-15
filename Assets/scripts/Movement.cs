using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSPeed=2;
    public float rotateSpeed=90;
    float upTarget = 0;
    float up;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            transform.Translate(Vector3.forward *Input.GetAxis("Vertical")* moveSPeed * Time.deltaTime);
            transform.Translate( Vector3.right * Input.GetAxis("Horizontal") * moveSPeed * Time.deltaTime);

            if (Input.GetKey(KeyCode.Q))
                upTarget = -1;
            if(Input.GetKey(KeyCode.E))
                upTarget = 1;
        if (!Input.GetKey(KeyCode.Q) && !Input.GetKey(KeyCode.E))
            upTarget = 0;
        up = Mathf.Lerp(up, upTarget, 0.1f);
        transform.Translate(Vector3.up *up * moveSPeed * Time.deltaTime);





    }
}
