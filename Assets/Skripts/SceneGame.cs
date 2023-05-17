using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneGame : MonoBehaviour
{
    public Button btn_play;
    void Start()
    {
        btn_play.onClick.AddListener(Load);
    }

    void Load()
    {
        SceneManager.LoadScene("Game");
    }
}
