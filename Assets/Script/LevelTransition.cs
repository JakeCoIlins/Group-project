using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

  
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            LoadLevel2();
        }
    }
}