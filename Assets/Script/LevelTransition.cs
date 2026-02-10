using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    
    public void SampleScene()
    {
        SceneManager.LoadScene("Sample Scene");
    }

  
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            SampleScene();
        }
    }
}