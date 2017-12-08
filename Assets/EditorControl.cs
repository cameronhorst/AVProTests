using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorControl : MonoBehaviour {

    public KeyCode cameronToggleKey = KeyCode.C;
    public float minAngleFromDown = 10;
    public float minAngleFromUp =10;
    public GameObject Frame;
    public AnimationCurve lerpCurve;

    private Transform localT;   //small optimization over the gameObject.transform convenience function
    private Vector3 lastMousePos;
    private bool overrideUserControl = false;


	// Use this for initialization
	void Start () {
        localT = transform;

	}


	// Update is called once per frame
	void Update ()
    {


    if (Input.GetMouseButton(0))
    {
        float xInput = Input.GetAxis("Mouse X");
        float yInput = Input.GetAxis("Mouse Y");

        transform.Rotate(0f, -xInput * 3f, 0f, Space.World);

        if (yInput < 0 && Vector3.Angle(transform.forward, Vector3.up) >= minAngleFromUp)
        {
            transform.Rotate(yInput * 3f, 0f, 0f, Space.Self);
        }
        else if (yInput > 0 && Vector3.Angle(transform.forward, Vector3.down) >= minAngleFromDown)
        {
            transform.Rotate(yInput * 3f, 0f, 0f, Space.Self);
        }
    }          
        
        
    }
}
