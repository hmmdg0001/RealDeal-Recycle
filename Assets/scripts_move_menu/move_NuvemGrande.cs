using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move_NuvemGrande : MonoBehaviour
{
    // Start is called before the first frame update

public int muda = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x > 1100){
            muda = 1;
        }

        if (this.transform.position.x < 100){
            muda = 0;
        }

    if(muda==1) transform.Translate (-1.5f , 0f, 0f);
    if(muda==0) transform.Translate (1.5f , 0f, 0f);
    }


}
