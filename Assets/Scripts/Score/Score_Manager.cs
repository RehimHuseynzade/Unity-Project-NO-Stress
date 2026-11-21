using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private Enemy_InstanceManager _enemyInstanceManager;
    public int FinalScore;
    private bool EnemyCekt=true;

    private void OnEnable()
    {
        FinalScore = 0;
        _scoreText.text = "" + FinalScore;
    }

    public void ScoreUpdate(int ScorePlus)
    {
        FinalScore += ScorePlus;
        _scoreText.text = "" + FinalScore;
    }

    private void Update()
    {
        if (EnemyCekt)
        {
            if (FinalScore >= 20 && _enemyInstanceManager.PrefabNumber == 1)
            {
                _enemyInstanceManager.PrefabNumber++;
            }
            else if (FinalScore >= 35 && _enemyInstanceManager.PrefabNumber == 2)
            {
                _enemyInstanceManager.PrefabNumber++;
            }
            else if (FinalScore >= 50 && _enemyInstanceManager.PrefabNumber == 3)
            {
                _enemyInstanceManager.PrefabNumber++;
            }
            else if (FinalScore >= 60 && _enemyInstanceManager.PrefabNumber == 4)
            {
                _enemyInstanceManager.PrefabNumber++;
            }
            else
            {
                EnemyCekt = true;
            }
        }
    }

}
