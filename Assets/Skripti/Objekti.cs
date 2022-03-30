using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabā ainā esošo kanvu
	public Canvas kanva;
	//GameObject, kas uzglabās velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cements;
	public GameObject e46;
	public GameObject ekskavators;
	public GameObject police;
	public GameObject traktorsD;
	public GameObject traktorsZ;
	public GameObject ugunsdzeseji;

	//Uzglabā velakmo objektu sākotnējās atrašanās vietas koordinātas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cementsKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 ekskavatorsKoord;
	[HideInInspector]
	public Vector2 policeKoord;
	[HideInInspector]
	public Vector2 traktorsDKoord;
	[HideInInspector]
	public Vector2 traktorsZKoord;
	[HideInInspector]
	public Vector2 ugunsdzesejiKoord;

	//Uzglabās audio avotu, kurā atskaņot attēlu skaņas efektus
	public AudioSource skanasAvots;
	//Masīvs, kas uzglabā visas iespējamās skaņas
	public AudioClip[] skanaKoAtskanot;
	//Mainīgais piefiksē vai objekts nolikts īstajāvietā (true/false)
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//Uzglabās pēdējo objektu, kurš pakustināts
	public GameObject pedejaisVIlktais = null;
	public int punkti=0;
	public GameObject Uzvara;
	public GameObject restart;

	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		b2Koord = b2.GetComponent<RectTransform>().localPosition;
		cementsKoord = cements.GetComponent<RectTransform>().localPosition;
		e46Koord = e46.GetComponent<RectTransform>().localPosition;
		ekskavatorsKoord = ekskavators.GetComponent<RectTransform>().localPosition;
		policeKoord = police.GetComponent<RectTransform>().localPosition;
		traktorsDKoord = traktorsD.GetComponent<RectTransform>().localPosition;
		traktorsZKoord = traktorsZ.GetComponent<RectTransform>().localPosition;
		ugunsdzesejiKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;
		Uzvara.SetActive(false);
		restart.SetActive(false);
	}
}
