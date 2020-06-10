using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button exitButton;

    void TaskOnClick()
    {
        Application.Quit();
    }

    void Start()
    {
        exitButton.onClick.AddListener (TaskOnClick);
    }
}
