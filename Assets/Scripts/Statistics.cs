using System;
using UnityEngine;

public class Statistics : SingletonMonoBehavior<Statistics>
{
    #region Variables

    private int _score;

    #endregion


    #region Events

    public event Action<int> OnScoreChanged;

    #endregion
    
    
    #region Public methods

    public void IncrementScore(int score)
    {
        _score += score;
        OnScoreChanged?.Invoke(_score);
    }

    #endregion
}