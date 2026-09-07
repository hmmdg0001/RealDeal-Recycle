using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_nuvem_2 : MonoBehaviour
{
public int muda = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x > 1500){
            muda = 1;
    }

        if (this.transform.position.x < -250){
            muda = 0;
    }

    if(muda==1) transform.Translate (-1.5f, 0f, 0f);
    if(muda==0) transform.Translate (1.5f, 0f, 0f);


}
}