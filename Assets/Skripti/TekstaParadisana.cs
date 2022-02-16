using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {
	//Uzglabās tekstu, kurš paņemts no input lauka
	public string teksts;
	//Lauks no, kura es tekstu paņemšu
	public GameObject ievadesLauks;
	//Teksta objekts, kur attēlot mainīga teksts saturu
	public GameObject tekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text>().text = "Sveiks "+teksts.ToUpper()+"!";
	}
}
