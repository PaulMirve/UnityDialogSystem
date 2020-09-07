using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public Dialog conversation;
    public GameObject dialog;

    private DialogScript dialogScript;
    private int currentLineIndex;

    private void Awake()
    {
        References.dialogManager = this;
    }
    private void Start()
    {
        dialogScript = dialog.GetComponent<DialogScript>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FollowConveration();
        }
    }
    public void FollowConveration()
    {
        if (currentLineIndex < conversation.lines.Length)
        {
            Line currentLine = conversation.lines[currentLineIndex];
            dialogScript.Dialog = currentLine.text;
            dialogScript.Name = currentLine.character.name;
            dialogScript.Image = currentLine.character.portraits.FirstOrDefault(sprite => sprite.name == currentLine.spriteName).image;
            currentLineIndex++;
        }
        else
        {
            currentLineIndex = 0;
            References.player.canMove = true;
            dialog.SetActive(false);
        }
    }
}
