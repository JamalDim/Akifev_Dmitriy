using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMenu : MonoBehaviour
{
    public Button btn_menu;
    void Start()
    {
        btn_menu.onClick.AddListener(Load);
    }
    
    void Load()
    {
        SceneManager.LoadScene("Menu");
    }
}
