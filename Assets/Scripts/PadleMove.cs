using UnityEngine;

public class PadleMove : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,-2.75f,0);
        
    }
}
