using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LouseWindow_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _louseWindowFinalScore;
    [SerializeField] private GameOver_PlayAgain _gameOver_PlayAgain;
    [SerializeField] private TextMeshProUGUI _louseWindowLevelBar;
    [SerializeField] private Score_Manager _score_Manager;
    private Level_PlayerPrefs _level_PlayerPrefs;
    [SerializeField] private AudioClip _buttonMusic;
    [SerializeField] private AudioSource _audioSourceAll;
    private void Awake()
    {
        _level_PlayerPrefs = GameObject.Find("PlayerPerfs").GetComponent<Level_PlayerPrefs>();
    }
    public void GameoverMethod()
    {
        gameObject.SetActive(true);
        _louseWindowFinalScore.text = "Score:" + _score_Manager.FinalScore;
        _louseWindowLevelBar.text = "Level:" + _level_PlayerPrefs.Level;
    }

    public void PlayAgainMethod()
    {
        _audioSourceAll.PlayOneShot(_buttonMusic);
        _gameOver_PlayAgain.PlayAgain();
    }

    public void MaineMenu()
    {
        _audioSourceAll.PlayOneShot(_buttonMusic);
        SceneManager.LoadScene("ManineMenu");
    }

}
