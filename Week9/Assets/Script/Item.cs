using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    [TextArea]
    public string title;

    [TextArea(3, 10)]
    public string description;

    [Header("Audio")]
    public AudioClip audioClip;

    [Header("Score")]
    public int score;
}
