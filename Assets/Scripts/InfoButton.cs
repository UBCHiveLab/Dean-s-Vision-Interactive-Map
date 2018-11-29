using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoButton : MonoBehaviour {

    public GameObject Info;
    bool ShowOrHide;

	// Use this for initialization
	void Start () {
        ShowOrHide = true;
        ShowHide();

        this.gameObject.GetComponent<Button>().onClick.AddListener(ShowHide);
	}

    private void ShowHide()
    {
        if (ShowOrHide)
        {
            ShowOrHide = false;
        } else
        {
            ShowOrHide = true;
        }

        Info.GetComponent<Renderer>().enabled = ShowOrHide;
    }
}
