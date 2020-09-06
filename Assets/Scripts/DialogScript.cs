using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogScript : MonoBehaviour
{
    public Image image;
    public new Text name;
    public Text dialog;

    public string Dialog
    {
        set => dialog.text = value;
    }
    public string Name
    {
        set => name.text = value;
    }
    public Sprite Image
    {
        set => image.sprite = value;
    }
}
