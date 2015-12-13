using UnityEngine;
using System.Collections;

public class ButtonEvent : MonoBehaviour {

    public void SaveClick()
    {
        SceneInit obj = GameObject.FindWithTag("GameController").GetComponent<SceneInit>();
        SaveLoadStatus.Save(obj.gameStatus);
    }

    public void LoadClick()
    {
        GameStatus status = SaveLoadStatus.Load();
        Debug.Log(status);
    }
}
