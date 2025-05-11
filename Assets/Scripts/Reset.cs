using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    
  
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
