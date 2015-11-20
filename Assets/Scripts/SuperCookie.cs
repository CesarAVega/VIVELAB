using UnityEngine;
using System.Collections;

public class SuperCookie :  Cookie{

    public float angulo;
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.down, angulo);
	}
}
