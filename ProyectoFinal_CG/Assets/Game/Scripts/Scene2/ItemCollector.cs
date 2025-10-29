using UnityEngine;
using TMPro;  

public class ItemCollector : MonoBehaviour
{
    private int score = 0;
    private int items = 0;

    [Header("UI")]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI itemText;

    private void Start()
    {
        UpdateUI();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            score += 10;
            items += 1;
            UpdateUI();
            Destroy(other.gameObject);
        }
    }

    void UpdateUI()
    {
        if (scoreText != null)
            scoreText.text = score.ToString("00");

        if (itemText != null)
            itemText.text = items.ToString("00");
    }
}
