using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLose : MonoBehaviour
{
    public Button btn_restart;
    void Start()
    {
        btn_restart.onClick.AddListener(Load);
    }

 
    void Load() 
    {
        SceneManager.LoadScene("Game");
    }
}
