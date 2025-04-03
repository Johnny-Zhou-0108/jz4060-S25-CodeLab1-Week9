using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public Item bomb;
    public Item bonus;
    public Item normal;
    
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public TextMeshProUGUI score;
    
    public AudioSource audioSource;
    
    public RawImage Ending;
    

    private int currentScore = 0;

    public void OnButtonPressed()
    {
        Item selectedAsset = GetRandomAsset();

        title.text = selectedAsset.title;
        description.text = selectedAsset.description;

        audioSource.clip = selectedAsset.audioClip;
        audioSource.Play();

        currentScore += selectedAsset.score;
        score.text = "Score: " + currentScore;

        if (selectedAsset == bomb)
        {
            Ending.gameObject.SetActive(true);
        }
    }

    private Item GetRandomAsset()
    {
        int index = Random.Range(0, 3);
        switch (index)
        {
            case 0: return bomb;
            case 1: return bonus;
            case 2: return normal;
            default: return normal;
        }
    }
}