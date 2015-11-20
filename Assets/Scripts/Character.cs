using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public GameSettings settings;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>(); //captura el componente Rigidbody del GameObject
	}
	
	// Update is called once per frame
	void Update () { // este update puede variar
	
	}

    void FixedUpdate() { //llama el update en un momento fijo
        float moveHorizontal = Input.GetAxis("Horizontal"); //obtener el input horizontal
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f); // vector en 3D de movimiento solo movimiento en X
        //Debug.Log("");  //print
        rb.AddForce(movement * settings.speed);
        float moverVetical = Input.GetAxis("Vertical"); //obtener el input vertical
        movement = new Vector3(0.0f, 0.0f, moverVetical); // vector en 3D de movimiento solo movimiento en X
        //Debug.Log("");  //print
        rb.AddForce(movement * settings.speed);
    }
}
