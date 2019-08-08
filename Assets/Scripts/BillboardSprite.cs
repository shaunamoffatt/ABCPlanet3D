using UnityEngine;

public class BillboardSprite : MonoBehaviour
{
    // Update is called once per frame
    void LateUpdate()
    {
        transform.forward = Camera.main.transform.forward;
    }
}