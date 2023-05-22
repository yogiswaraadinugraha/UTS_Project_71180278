using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public Canvas help;
    
    public void CloseHelpCanvas()
    {
        help.enabled = false;
    }
}
