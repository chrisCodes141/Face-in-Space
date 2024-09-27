using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copier : MonoBehaviour
{
    public GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x1 = parent.transform.position.x;
        float y1 = parent.transform.position.y;
        if (x1 > 11.3F)
        {
            x1 = -11.3F;
        }
        if (x1 < -11.3F)
        {
            x1 = 11.3F;
        }
        if (y1 > 5F)
        {
            y1 = -5F;
        }
        if (y1 < -5F)
        {
            y1 = 5F;
        }
        parent.transform.position = new Vector2(x1, y1);
    }
}
