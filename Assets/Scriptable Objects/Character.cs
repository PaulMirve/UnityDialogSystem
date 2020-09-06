using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Portrait
{
    public string name;
    public Sprite image;
}

[System.Serializable]
public struct CharacterSprite
{
    public string name;
    public Sprite image;
}

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public new string name;
    public Portrait[] portraits;
    public CharacterSprite[] sprites;
    public Dialog[] dialogs;
}
