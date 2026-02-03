using UnityEngine;

public class DisappearOnStand : MonoBehaviour
{
    private Renderer blockRenderer;
    private Collider blockCollider;

    void Start()
    {
        blockRenderer = GetComponent<Renderer>();
        blockCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(DisappearRoutine());
        }
    }

    private System.Collections.IEnumerator DisappearRoutine()
    {
       
        blockRenderer.enabled = false;
        blockCollider.enabled = false;

        
        yield return new WaitForSeconds(5f);

        
        blockRenderer.enabled = true;
        blockCollider.enabled = true;
    }
}