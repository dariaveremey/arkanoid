using UnityEngine;
using UnityEngine.SceneManagement;

public class LostZone : MonoBehaviour
{
    #region Private methods

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Ball ball))
        {
            Destroy(ball.gameObject);
            RestartLevel();
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("GameScene");
    }

    #endregion
}