using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NomesanasVieta : MonoBehaviour, IDropHandler {
	//Uzglabās velkamā objekta un nomešanas lauka z rotāciju,
	// kāarī rotācijas un izmēru pieļaujamo starpību
	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm;
	//Norāde uz Objekti skriptu
	public Objekti objektuSkripts;

	//Nostrādās, ja objektu cenšas nomest uz jebkuras nomešanas  vietas
	public void OnDrop(PointerEventData notikums)
	{
		//Pārbauda vai tika vilkts un atlaists vispār kāds objekts
		if (notikums.pointerDrag != null)
		{
			//Ja nomešanas vietas tags sakrīt ar vilktā objekta tagu
			if (notikums.pointerDrag.tag.Equals(tag))
			{
				//Iegūst objekta rotāciju grādos
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform>().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform>().eulerAngles.z;
				//Aprēkina abu objektu z rotācijas starpību
				rotacijasStarpiba = Mathf.Abs(vietasZrot - velkObjZrot);
				//Līdzīgi kā ar Z rotāciju, jāpiefiksē objektu izmēri pa x un y asīm, kā arī starpība
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform>().localScale;
				velkObjIzm = GetComponent<RectTransform>().localScale;
				xIzmeruStarp = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs(vietasIzm.y - velkObjIzm.y);


				//Pārbauda vai objektu rotācijas un izmēru starpība ir pieļaujamajās robēžās
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
				   && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1))
				{
					objektuSkripts.vaiIstajaVieta = true;
					//Noliktais objekts smuki iecentrējas nomešanas laukā
					notikums.pointerDrag.GetComponent<RectTransform>().anchoredPosition
								= GetComponent<RectTransform>().anchoredPosition;
					//Rotācijai
					notikums.pointerDrag.GetComponent<RectTransform>().localRotation
								= GetComponent<RectTransform>().localRotation;
					//Izsmēram
					notikums.pointerDrag.GetComponent<RectTransform>().localScale
					= GetComponent<RectTransform>().localScale;

					//Pārbauda tagu un atskaņo atbilstošo skaņas efektu
					switch (notikums.pointerDrag.tag)
					{
						case "Atkritumi":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[1]);
							objektuSkripts.punkti++;
							break;

						case "Slimnica":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[2]);
							objektuSkripts.punkti++;
							break;

						case "Skola":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[3]);
							objektuSkripts.punkti++;
							break;
						case "b2":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[4]);
							objektuSkripts.punkti++;
							break;
						case "cements":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[5]);
							objektuSkripts.punkti++;
							break;
						case "e46":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[11]);
							objektuSkripts.punkti++;
							break;
						case "ekskavators":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[7]);
							objektuSkripts.punkti++;
							break;
						case "police":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[6]);
							objektuSkripts.punkti++;
							break;
						case "trakstorsD":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[8]);
							objektuSkripts.punkti++;
							break;
						case "traktorsZ":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[9]);
							objektuSkripts.punkti++;
							break;
						case "Ugunsdzeseji":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[10]);
							objektuSkripts.punkti++;
							break;
						default:
							Debug.Log("Nedefinēts tags!");
							break;
					}

				}

				//Ja objekts nomests nepareizajā laukā
			}
			else
			{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[0]);

				//Objektu aizmet uz sākotnējo pozīciju
				switch (notikums.pointerDrag.tag)
				{
					case "Atkritumi":
						objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition
								= objektuSkripts.atkrKoord;
						break;

					case "Slimnica":
						objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition
						= objektuSkripts.atroKoord;
						break;

					case "Skola":
						objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition
						= objektuSkripts.bussKoord;
						break;
					case "b2":
						objektuSkripts.b2.GetComponent<RectTransform>().localPosition
					= objektuSkripts.b2Koord;
						break;
					case "cements":
						objektuSkripts.cements.GetComponent<RectTransform>().localPosition
					= objektuSkripts.cementsKoord;
						break;
					case "e46":
						objektuSkripts.e46.GetComponent<RectTransform>().localPosition
					= objektuSkripts.e46Koord;
						break;
					case "ekskavators":
						objektuSkripts.ekskavators.GetComponent<RectTransform>().localPosition
					= objektuSkripts.ekskavatorsKoord;
						break;
					case "police":
						objektuSkripts.police.GetComponent<RectTransform>().localPosition
					= objektuSkripts.policeKoord;
						break;
					case "traktorsD":
						objektuSkripts.traktorsD.GetComponent<RectTransform>().localPosition
					= objektuSkripts.traktorsDKoord;
						break;
					case "traktorsZ":
						objektuSkripts.traktorsZ.GetComponent<RectTransform>().localPosition
					= objektuSkripts.traktorsZKoord;
						break;
					case "Ugunsdzeseji":
						objektuSkripts.ugunsdzeseji.GetComponent<RectTransform>().localPosition
					= objektuSkripts.ugunsdzesejiKoord;
						break;
					default:
						Debug.Log("Nedefinēts tags!");
						break;
				}

			}
		}

		if (objektuSkripts.punkti == 11)
		{
			objektuSkripts.Uzvara.SetActive(true);
			objektuSkripts.restart.SetActive(true);
		}
	}
}