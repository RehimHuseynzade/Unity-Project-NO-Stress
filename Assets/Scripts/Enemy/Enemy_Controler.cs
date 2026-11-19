using UnityEngine;

public class Enemy_Controler : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private int Score;
    [SerializeField] private int LevelScore;
    private Score_Manager _score_Manager;
    private LevelBar_Manager _levelBar_Manager;
    private void Update()
    {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
    }

    private void Start()
    {
        GameObject LevelManager = GameObject.Find("LevelManager");
        GameObject ScoreManager = GameObject.Find("Score");

        _levelBar_Manager=LevelManager.GetComponent<LevelBar_Manager>();
        _score_Manager=ScoreManager.GetComponent<Score_Manager>();
    }

    private void OnDisable()
    {
            _score_Manager.ScoreUpdate(Score);
            _levelBar_Manager.LevelUpdate(LevelScore);
    }
}

