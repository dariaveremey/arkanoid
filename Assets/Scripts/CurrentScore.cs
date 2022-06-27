using UnityEngine;

public class CurrentScore : SingletonMonoBehavior<CurrentScore>
{
    public int ScoreNumber;


    #region Public methods

    public void Score(int blockUtility)
    {
        ScoreNumber += blockUtility;
        Debug.Log($"{ScoreNumber}");
    }

    #endregion
}