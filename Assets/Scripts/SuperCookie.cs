using UnityEngine;
using System.Collections;

public class SuperCookie :  Cookie {

    public GameSettings settings;

    // Update is called once per frame
    void Update () {
        transform.Rotate(Vector3.down, settings.AnguloRotar);
	}
}
