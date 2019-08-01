using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeController : MonoBehaviour
{
    public enum EYETYPE { Normal, Closed, Wide, Left, Right, Smile, Squint, Small, Dead };
    public EYETYPE type;
    EYETYPE previousType;

    Renderer rend;
    
    float u = 0;
    float v = 0;

    void Start()
    {
        rend = GetComponent<Renderer>();
        type = EYETYPE.Normal;
        previousType = EYETYPE.Normal;
    }
    // Update is called once per frame
    void Update()
    {
        if (type != previousType)
        {
            SetUVPos();
            rend.material.SetTextureOffset("_MainTex", new Vector2(u, v));
        }

    }

    void SetUVPos() {
        switch (type)
        {
            case (EYETYPE.Normal):
                u = 0; v = 0;
                break;
            case (EYETYPE.Closed):
                u = 0; v = 0.66f;
                break;
            case (EYETYPE.Wide):
                u = 0; v = 0.33f;
                break;
            case (EYETYPE.Left):
                u = 0.33f; v = 0;
                break;
            case (EYETYPE.Right):
                u = 0.33f; v = 0;
                break;
            case (EYETYPE.Smile):
                u = 0; v = 0;
                break;
            case (EYETYPE.Squint):
                u = 0; v = 0;
                break;
            case (EYETYPE.Small):
                u = 0; v = 0;
                break;
            case (EYETYPE.Dead):
                u = 0; v = 0;
                break;

        }
    }
}
