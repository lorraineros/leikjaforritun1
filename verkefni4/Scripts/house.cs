using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class house : MonoBehaviour
{
    public GameObject completeLevelUI;
    void OnTriggerEnter2D()
    {
        LevelComplete();
    }
    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
    }
}
