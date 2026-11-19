using UnityEngine;

public class GameOver_PlayAgain:MonoBehaviour
{
    [SerializeField] private GameObject _Canvas;
    [SerializeField] private Enemy_InstanceManager _enemy_InstanceManager;
    [SerializeField] private LouseWindow_Manager _louseWindow_Manager;
    [SerializeField] private GameObject _player;
    [SerializeField] private AudioSource _audioSourceBackRound;
    [SerializeField] private AudioClip _gameOverMusics;
    [SerializeField] private AudioSource _audioSourceAll;
   private Level_PlayerPrefs _level_PlayerPrefs;

    private void Awake()
    {
        _level_PlayerPrefs = GameObject.Find("PlayerPerfs").GetComponent<Level_PlayerPrefs>();
    }
    public void GameOver()  
    {
        _player.gameObject.SetActive(false);
        _Canvas.gameObject.SetActive(false);
        _enemy_InstanceManager.GameoverMethod();
        _louseWindow_Manager.GameoverMethod();
        _enemy_InstanceManager.PrefabNumber = 1;
        _audioSourceAll.PlayOneShot(_gameOverMusics);
        _audioSourceBackRound.Stop();
        _level_PlayerPrefs.Save();
    }

    public void PlayAgain()
    {
        _louseWindow_Manager.gameObject.SetActive(false);
        _player.SetActive(true);
        _enemy_InstanceManager.gameObject.SetActive(true);
        _Canvas.SetActive(true);
        _audioSourceBackRound.Play();
    }
}
