using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    [SerializeField] int scenetoload = 0;
    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetSceneAt(scenetoload).name);
    }

  
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Level1();
        }
    }
}