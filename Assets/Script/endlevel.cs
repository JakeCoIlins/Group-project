using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] int scenetoload = 0;
    [SerializeField] public Scene targetscene;
    [SerializeField] public string scenename2;

    public void OnTriggerEnter()
    {
        SceneManager.LoadScene(0);
    }
}