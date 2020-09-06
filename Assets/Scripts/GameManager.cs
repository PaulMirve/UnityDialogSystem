using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject dialogUI;

    private void Awake()
    {
        References.dialog = dialogUI;
    }
}
