using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    [SerializeField] private AudioClip _buttonMusic;
    [SerializeField] private AudioSource _audioSourceAll;
    public void PlayButton()
    {
        _audioSourceAll.PlayOneShot(_buttonMusic);
        SceneManager.LoadScene("GameScene");
    }
}
