using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int catsCollected;

    [SerializeField] TextMeshProUGUI catNumberUI;

    [SerializeField] GameObject panel;

    private void Start()
    {
        catNumberUI.text = catsCollected.ToString();
    }
    public int GotCat()
    {
        catsCollected++;
        catNumberUI.text = catsCollected.ToString();

        if (catsCollected >= 8)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
        }

        return catsCollected;
    }
}
