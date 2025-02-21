using UnityEngine;

public class OnMouseOverColor : MonoBehaviour
{
    Color _MouseOverColor = Color.blue;
    
    
    
    Color _OriginalColor;
    MeshRenderer _Renderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _Renderer = GetComponent<MeshRenderer>();
        _OriginalColor = _Renderer.material.color;
    }
    void OnMouseOver()
    {
        _Renderer.material.color = _MouseOverColor;
        transform.localScale = new Vector3(2f, 2f, 2f);
    }
    
    void OnMouseExit()
    {
        _Renderer.material.color = _OriginalColor;
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
