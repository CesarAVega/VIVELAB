using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>(); //captura el componente Rigidbody del GameObject
	}
	
	// Update is called once per frame
	void Update () { // este update puede variar
	
	}

    void FixedUpdate() { //llama el update en un momento fijo
        float moveHorizontal = Input.GetAxis("Horizontal"); //obtener el inpunt horizontal
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f); // vector en 3D de movimiento solo movimiento en X
        //Debug.Log("");  //print
        rb.AddForce(movement * speed);
        float moveVetical = Input.GetAxis("Vertical"); //obtener el inpunt horizontal
        Vector3 movment = new Vector3(0.0f, 0.0f, moveVetical); // vector en 3D de movimiento solo movimiento en X
        rb.AddForce(movment * speed);
    }
}
