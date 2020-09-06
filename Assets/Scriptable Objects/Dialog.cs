using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Line
{
    public Character character;
    public string spriteName;
    [TextArea(2, 5)]
    public string text;
}

[CreateAssetMenu(fileName = "New Dialog", menuName = "Dialog")]
public class Dialog : ScriptableObject
{
    public Character[] characters;
    public Line[] lines;
}
