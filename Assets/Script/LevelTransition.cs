using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    [SerializeField] int scenetoload = 0;
    [SerializeField] public Scene targetscene;
    [SerializeField] public string scenename;

    public void Level1()
    {
        Debug.Log("level loaded");
        SceneManager.LoadScene(scenename);
    }

  
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Level1();
        }
    }
}