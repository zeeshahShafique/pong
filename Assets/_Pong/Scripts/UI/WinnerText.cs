using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _winnerTMP;
    [SerializeField] private RectTransform _rect;
    private void OnEnable()
    {
        _winnerTMP = GetComponentInChildren<TextMeshProUGUI>();
        _rect = GetComponent<RectTransform>();
        _rect.anchoredPosition = Vector2.left * 1000;
        GameManager.OnPlayerWon += SetPlayerWonText;
        GameManager.OnAIWon += SetAIWonText;
    }

    private void OnDisable()
    {
        GameManager.OnPlayerWon -= SetPlayerWonText;
        GameManager.OnAIWon -= SetAIWonText;
    }

    void SetPlayerWonText()
    {
        _rect.anchoredPosition = Vector2.zero;
        _winnerTMP.SetText("Player Won!");
    }

    void SetAIWonText()
    {
        _rect.anchoredPosition = Vector2.zero;
        _winnerTMP.SetText("AI Won!");
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
