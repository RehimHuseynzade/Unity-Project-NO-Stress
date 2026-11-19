using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] private GameOver_PlayAgain _gameOver_PlayAgain;
    [SerializeField] private Enemy_Controler _enemycontroler;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
              _gameOver_PlayAgain.GameOver();
        }
    }
}
