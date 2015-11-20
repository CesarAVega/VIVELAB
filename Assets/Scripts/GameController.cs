using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject superCookie;

    private GameObject activeSuperCookie;

	// Use this for initialization
	void Start () {
        activeSuperCookie = Instantiate(superCookie);
        StartCoroutine(ScheduleCookieDestroy());
  	}

    IEnumerator ScheduleCookieDestroy() {
        yield return new WaitForSeconds(3.0f);
        Destroy(activeSuperCookie);
    }
}
