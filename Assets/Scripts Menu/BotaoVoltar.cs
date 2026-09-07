using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotaoVoltar : MonoBehaviour
{
    public GameObject botao_voltar;
    public int VoltarBtn = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (VoltarBtn == 1)
        {
            botao_voltar.SetActive(false);
        }
    }
}
