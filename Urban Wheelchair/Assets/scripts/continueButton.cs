﻿using UnityEngine;
using System.Collections;

public class continueButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.visible = true;

    }
	
	// Update is called once per frame
	void Update () {

    }

    public void loadLevel() {
        //Debug.Log("button clicked");
        varGlobales.isCamFauteuil = false;
        varGlobales.isFinished = false;
        varGlobales.tempsLast = (int) varGlobales.tempsActuel;
        varGlobales.isFirstTime = false;
        varGlobales.etatJeu = 1;
        varGlobales.moneyStart = 30000;
        Application.LoadLevel("mainScene");
    }
}
