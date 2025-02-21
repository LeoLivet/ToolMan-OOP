using UnityEngine;

public class PushCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (axis)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        
    }
}
