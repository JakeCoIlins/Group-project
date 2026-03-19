using UnityEngine;
using TMPro;

public class CoinCollection : MonoBehaviour
{
    private int Coin = 0;

    public TextMeshProUGUI CoinText;

    private void Start()
    {
        
        UpdateCoinText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Coin++;
            UpdateCoinText();
            Debug.Log("Coins collected: " + Coin);
            Destroy(other.gameObject);
        }
    }

    private void UpdateCoinText()
    {
        if (CoinText != null)
        {
            CoinText.text = "Coin: " + Coin.ToString();
        }
        else
        {
            Debug.LogWarning("CoinText is not assigned in the inspector.");
        }
    }
}