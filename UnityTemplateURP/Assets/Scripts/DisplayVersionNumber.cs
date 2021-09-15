using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayVersionNumber : MonoBehaviour
{
    private bool leftShift = false;
    private bool rightShift = false;

    public Text versionText;

    // Start is called before the first frame update
    void Start()
    {
        versionText.text = "v" + Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            leftShift = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)) {
            leftShift = false;
        }
        if (Input.GetKeyDown(KeyCode.RightShift)) {
            rightShift = true;
        }
        if (Input.GetKeyUp(KeyCode.RightShift)) {
            rightShift = false;
        }

        if (leftShift && rightShift)
        {
            if (versionText.gameObject.activeInHierarchy)
            {
                versionText.gameObject.SetActive(false);
            }
            else
            {
                versionText.gameObject.SetActive(true);
            }
            leftShift = false;
            rightShift = false;
        }
    }
}
