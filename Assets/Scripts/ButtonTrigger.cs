using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveToScene(int scenID)
    {
        SceneManager.LoadScene(scenID);
    }
}
