using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu_visibilidade : MonoBehaviour
{
    public GameObject menu_def;
    public GameObject menu_start;
    public Button bt_def;
    public int v_visibilidade = 0;

    // Update is called once per frame
    void Start()
    {
        Button btn = bt_def.GetComponent<Button>();
        btn.onClick.AddListener(visibilidade);
    }
    void Update()
    {

        if (v_visibilidade == 1)
        {
            menu_def.SetActive(true);
            menu_start.SetActive(false);
            v_visibilidade = 0;
        }
        }
   public void visibilidade()
    {
    v_visibilidade = 1;

        
    }
}
