using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPD : MonoBehaviour
{
    public int angleX = 0;
    public int angleY = 0;
    public int angleZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ConfigurableJoint joint = this.GetComponent<ConfigurableJoint>(); 
        joint.targetRotation = Quaternion.Euler(angleX, angleY, angleZ);
    }
}
