using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar_Manager : MonoBehaviour
{
    private Level_PlayerPrefs _level_PlayerPrefs;
    [SerializeField] private Image _levelBar;
    [SerializeField] private TextMeshProUGUI _levelText;
    private float _maxLevelScore = 100;

    private void Awake()
    {
        _level_PlayerPrefs = GameObject.Find("PlayerPerfs").GetComponent<Level_PlayerPrefs>();
    }
    private void OnEnable()
    {
        _levelBar.fillAmount = _level_PlayerPrefs.LevelScoree / _maxLevelScore * 1;
        _levelText.text =""+_level_PlayerPrefs.Level;
    }

    public void LevelUpdate(float LevelScor)
    {
        _level_PlayerPrefs.LevelScoree+=LevelScor;
        if (_levelBar !=null)
        {
            _levelBar.fillAmount = _level_PlayerPrefs.LevelScoree / _maxLevelScore * 1;
        }
        if (_levelBar.fillAmount == 1f)
        {
            _level_PlayerPrefs.LevelScoree=0;
            _level_PlayerPrefs.Level++;
            _levelText.text = "" + _level_PlayerPrefs.Level;
        }
    }
}
