using TMPro;
using UnityEngine;

public class Level_TextManineMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _levelNumberText;
    private Level_PlayerPrefs _level_PlayerPrefs;
    private void Awake()
    {
        _level_PlayerPrefs = GameObject.Find("PlayerPerfs").GetComponent<Level_PlayerPrefs>();
    }

    private void Start()
    {
        _levelNumberText.text = _level_PlayerPrefs.Level.ToString();
    }
}
