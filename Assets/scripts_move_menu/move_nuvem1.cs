using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_nuvem1 : MonoBehaviour
{
public int muda = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x > 300){
            muda = 1;
    }

        if (this.transform.position.x < 200){
            muda = 0;
    }

    if(muda==1) transform.Translate (-1.5f, 0f, 0f);
    if(muda==0) transform.Translate (1.5f, 0f, 0f);


}
}