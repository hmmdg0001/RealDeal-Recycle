using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_montanha_solo : MonoBehaviour
{
public bool muda = false;

    // Update is called once per frame
    void Update()
    {

        if(this.transform.position.y > 960) muda = true;

        if (this.transform.position.y < 940) muda = false;

    if(muda == true)transform.Translate(0f, -0.8f, 0f);
    if(muda == false) transform.Translate(0f, 0.8f, 0f);
}
}