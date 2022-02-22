using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kursorsUzAttela : MonoBehaviour {

	public AudioSource skanasAvots;
	public AudioClip skanaKoAtskanot;

	public void uzbiditUzAttela(){
		skanasAvots.PlayOneShot (skanaKoAtskanot);
	}
	public void nobiditnoAttela(){
		skanasAvots.Stop ();
	}
}
