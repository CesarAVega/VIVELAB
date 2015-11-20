using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameSettings : ScriptableObject {

    public float speed;
    public float speedBoost;
    public float speedBoostDuration;
    public float AnguloRotar;

    public float cookieScore;
    public float speedUpCookieScore;

    public float cookieSpawnTime;
    public float cookeTimeLimit;
    public List<Vector3> SpawnPoints = new List<Vector3>();
}
