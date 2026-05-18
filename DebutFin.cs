using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebutFin : MonoBehaviour
{

    public GameObject goPlayer;
    public GameObject goBtnStart;
    public GameObject goTxtVictoire;
    public GameObject goPorte;
    public float anglePorte;

    // Start is called before the first frame update
    void Start()
    {
        goPlayer.SetActive(false);
        goTxtVictoire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!goTxtVictoire.activeSelf && goPorte.GetComponent<Transform>().localEulerAngles.y> anglePorte)
        {
            goPlayer.SetActive(false);
            goTxtVictoire.SetActive(true);
            goPorte.GetComponent<Rigidbody>().isKinematic = true;

        }
    }

    public void Demarrer()
    {
        goPlayer.SetActive(true);
        goBtnStart.SetActive(false);
    }
}
