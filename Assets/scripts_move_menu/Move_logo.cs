using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_logo : MonoBehaviour
{
    public int muda = 0;

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y > 1900) muda = 1;

        if (this.transform.position.y < 1750) muda = 0;

        if (muda == 1) transform.Translate(0f, -0.8f, 0f);
        if (muda == 0) transform.Translate(0f, 0.8f, 0f);
}
}
