using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secCam : MonoBehaviour
{
    public Camera mainCam;
    public Camera secondCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam=Camera.main;
        secondCam=this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Lc");
            mainCam.enabled=false;
            secondCam.enabled=true;
        }
        if(Input.GetMouseButtonDown(1)){
            Debug.Log("Rc");
            mainCam.enabled=true;
            secondCam.enabled=false;
        }
    }
}
