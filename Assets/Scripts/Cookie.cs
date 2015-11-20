using UnityEngine;
using System.Collections;

public class Cookie : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        gameObject.SetActive(false);
    }
}
