using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Voltar_MainMenu : MonoBehaviour
{
   public void SwitchScene(string Menu_Principal)
    {
        SceneManager.LoadScene(Menu_Principal);
    }
}
