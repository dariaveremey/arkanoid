using UnityEngine;


public class Block : MonoBehaviour
{
    private int _numberStrikes;
    [SerializeField] private int _numberDestroy;
    [SerializeField] private int _points;
    [SerializeField] private float _firstCoefficient;
    [SerializeField] private float _secondCoefficient;

    [SerializeField] private Texture2D _firstDestroySpriteTexture2D;
    [SerializeField] private Texture2D _secondDestroySpriteTexture2D;

    private Sprite _firstChangedSpriteRenderer;
    private Sprite _secondChangedSpriteRenderer;

    private int _pointsNumber;

    private void OnCollisionEnter2D(Collision2D col)
    {
        _numberStrikes++;

        if (_numberStrikes == _numberDestroy)
        {
            _pointsNumber += _points;
            Destroy(gameObject);
            Debug.Log( $"{_pointsNumber}");
            
        }

        if (_numberStrikes== 1)
        {
            _firstChangedSpriteRenderer = Sprite.Create(_firstDestroySpriteTexture2D,
                new Rect(0.0f, 0.0f, _firstDestroySpriteTexture2D.width, _firstDestroySpriteTexture2D.height),
                new Vector2(0.5f, 0.5f), _firstCoefficient);
            GetComponent<SpriteRenderer>().sprite = _firstChangedSpriteRenderer;
        }

        if (_numberStrikes == 2)
        {
            _secondChangedSpriteRenderer = Sprite.Create(_secondDestroySpriteTexture2D,
                new Rect(0.0f, 0.0f, _secondDestroySpriteTexture2D.width, _secondDestroySpriteTexture2D.height),
                new Vector2(0.5f, 0.5f), _secondCoefficient);
            GetComponent<SpriteRenderer>().sprite = _secondChangedSpriteRenderer;
        }
        
        
    }
}