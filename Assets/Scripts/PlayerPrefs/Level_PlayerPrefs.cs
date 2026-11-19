using UnityEngine;

public class Level_PlayerPrefs : MonoBehaviour
{
    public int Level;
    public float LevelScoree;

    private void OnEnable()
    {
        DontDestroyOnLoad(gameObject);
        Level = PlayerPrefs.GetInt("Level", 0);
        LevelScoree = PlayerPrefs.GetFloat("LevelScore", 0);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("Level", Level);
        PlayerPrefs.SetFloat("LevelScore", LevelScoree);
        PlayerPrefs.Save();
    }
}
