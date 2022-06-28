using UnityEngine;

public class Block : MonoBehaviour
{
    #region Viriables

    [SerializeField] private int _numberDestroy;
    [SerializeField] private int _points;

    [SerializeField] private float _firstCoefficient;
    [SerializeField] private float _secondCoefficient;

    [SerializeField] private Texture2D _firstDestroySpriteTexture2D;
    [SerializeField] private Texture2D _secondDestroySpriteTexture2D;

    private Sprite _firstChangedSpriteRenderer;
    private Sprite _secondChangedSpriteRenderer;

    private int _pointsNumber;
    private int _numberStrikes;

    #endregion


    #region Unity lifecycle

    private void OnCollisionEnter2D(Collision2D col)
    {
        _numberStrikes++;

        if (_numberStrikes == _numberDestroy)
        {
            //_pointsNumber += _points;
            Destroy(gameObject);
            Debug.Log($"{_pointsNumber}");
        }

        if (_numberStrikes == 1)
        {
            Convent(_firstChangedSpriteRenderer, _firstDestroySpriteTexture2D, _firstCoefficient);
        }

        if (_numberStrikes == 2)
        {
            Convent(_secondChangedSpriteRenderer, _secondDestroySpriteTexture2D, _secondCoefficient);
        }
    }

    #endregion


    #region Private methods
    

    #endregion
    private void Convent(Sprite changeSprite, Texture2D currentTexture2D, float coefficient)
    {
        changeSprite = Sprite.Create(currentTexture2D,
            new Rect(0.0f, 0.0f, currentTexture2D.width, currentTexture2D.height),
            new Vector2(0.5f, 0.5f), coefficient);
        GetComponent<SpriteRenderer>().sprite = changeSprite;
    }

}