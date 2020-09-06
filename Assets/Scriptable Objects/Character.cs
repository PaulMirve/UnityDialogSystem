using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public CharacterSprite[] images;
}
