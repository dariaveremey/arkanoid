using UnityEngine;

public class Block : MonoBehaviour
{
    #region Viriables

    [SerializeField] private int _numberDestroy;
    [SerializeField] private int _points;

        //[SerializeField] private float _firstCoefficient;
    //[SerializeField] private float _secondCoefficient;

    //[SerializeField] private Texture2D _firstDestroySpriteTexture2D;
    //[SerializeField] private Texture2D _secondDestroySpriteTexture2D;

    
    
    [SerializeField] private Sprite[] _destroyedSprites;
    private SpriteRenderer _changedSpriteRenderer;
    
    
    
    //private Sprite _firstChangedSpriteRenderer;
    //private Sprite _secondChangedSpriteRenderer;

    private int _pointsNumber;
    private int _numberStrikes;

    #endregion


    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        _numberStrikes++;
        
        if (_numberStrikes == _numberDestroy)
        {
            Statistics.Instance.IncrementScore(_points);
            Destroy(gameObject);
            Debug.Log($"{_pointsNumber}");
        }




        if (_numberStrikes == 1)
        {
            _changedSpriteRenderer.sprite = _destroyedSprites[0];
        }

        if (_numberStrikes == 2)
        {
            _changedSpriteRenderer.sprite = _destroyedSprites[1];
        }
    }

    #endregion


    #region Private methods
    

    #endregion

    private void ChangingSprite()

    {
    
    }
    
    

}