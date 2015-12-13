using UnityEngine;
using System.Collections;

public class SceneInit : MonoBehaviour {

    public GameObject[] objects;
    public GameStatus gameStatus;

    // Use this for initialization
    void Start () {

        gameStatus = new GameStatus();
        gameStatus.statusList = new ObjectStatus[objects.Length];
        gameStatus.gameName = "JSON Serializer Test";

        for (int i = 0; i < objects.Length; i++)
        {
            ObjectStatus stat = new ObjectStatus();
            stat.id = i;
            stat.name = objects[i].name;
            stat.weight = Random.Range(1.0f, 10.0f);
            stat.position = objects[i].transform.position;

            gameStatus.statusList[i] = stat;
        }
    }
}
