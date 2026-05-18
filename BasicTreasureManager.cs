using System.Collections;
using System.Collections.Generic;
using TMPro;//A AJOUTER !!!!
using UnityEngine;

public class BasicTreasureManager : MonoBehaviour
{

	public static int score = 0;
	public GameObject goTxtScore;

	public static int nbCoffres = 0;

	public GameObject goPorte;
	public GameObject goParticules;

	void Start() {
		nbCoffres++;
		goTxtScore.GetComponent<TextMeshProUGUI>().text = "Trésors " + score + "/" + nbCoffres;
	}
	void Update() { }
	//Récupération d'un trésor 
	private void OnTriggerEnter(Collider other)
	{
		//Uniquement celui qui rentre en contact est bien le joueur 	
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);//Destruction du coffre 	
			score = score + 1;
			goTxtScore.GetComponent<TextMeshProUGUI>().text = "Trésors "+score+"/"+ nbCoffres;
			gameObject.GetComponentInParent<AudioSource>().Play();

			if (score>= nbCoffres)
            {//Tous les coffres ont bien été trouvés !
				goPorte.GetComponent<Rigidbody>().isKinematic = false;
				goParticules.GetComponent<ParticleSystem>().Play();
			}
		}
	}
}
