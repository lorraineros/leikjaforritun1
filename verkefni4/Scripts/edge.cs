using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edge : MonoBehaviour
{
    public GameObject NotcompleteLevelUI;
    void OnTriggerEnter2D()
    {
        LevelNotComplete();
    }
    public void LevelNotComplete()
    {
        NotcompleteLevelUI.SetActive(true);
    }
}
