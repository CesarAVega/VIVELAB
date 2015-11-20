using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public GameObject superCookie;
    public ScoreController score;
    public GameSettings settings;
    private GameObject activeSuperCookie;

    // Use this for initialization
    void Start () {
        StartCoroutine(ScheduleCookieCreate());
  	}

    IEnumerator ScheduleCookieDestroy() {
        yield return new WaitForSeconds(settings.cookeTimeLimit);
        Destroy(activeSuperCookie);
        StartCoroutine(ScheduleCookieCreate());
    }

    IEnumerator ScheduleCookieCreate() {
        yield return new WaitForSeconds(settings.cookieSpawnTime);
        activeSuperCookie = Instantiate(superCookie);
        activeSuperCookie.transform.position = settings.SpawnPoints[Random.Range(0, settings.SpawnPoints.Count)] ;
        activeSuperCookie.GetComponent<SuperCookie>().touched += HandleSuperCookieTouched;
        StartCoroutine(ScheduleCookieDestroy());
    }

    void HandleSuperCookieTouched() {
        score.setTotalScoreSuper();
    }
}
