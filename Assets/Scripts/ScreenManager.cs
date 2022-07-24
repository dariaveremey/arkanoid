using TMPro;
using UnityEngine;

public class ScreenManager: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreLable;

    private void Start()
    {
        Statistics.Instance.OnScoreChanged += SetScoreLable;
    }

    private void OnDestroy()
    {
        Statistics.Instance.OnScoreChanged -= SetScoreLable; 
    }

    private void SetScoreLable(int score)
    {
        _scoreLable.text = score.ToString();
    }
}
