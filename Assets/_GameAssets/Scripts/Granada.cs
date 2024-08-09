using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour {

    [SerializeField] int tiempoParaExplosion = 3;
    [SerializeField] int radioExplosion = 3;

    [SerializeField] int fuerzaExplosion = 100;

    [SerializeField] int alturaExplosion = 3;

    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        // RECOGER EL SONIDO
        audioSource = GetComponent<AudioSource>();

        Invoke("Explotar", tiempoParaExplosion);	
	}
	
	// Update is called once per frame
	void Explotar () {

        // SONIDO
        audioSource.Play();

        // RECOGEMOS TODO LO QUE TENGA COLLIDER EN LA POSICION DE LA BOMBA Y CON UN RADIO
        Collider[] cosas = Physics.OverlapSphere(transform.position, radioExplosion);
        foreach(var cosa in cosas) {
            if (cosa.tag == "CajasExplosionables") {
                //print(cosa.gameObject.name);
                cosa.gameObject.GetComponent<Rigidbody>().AddExplosionForce(
                        fuerzaExplosion, 
                        this.transform.position, // DESDE DENTRO DE LA GRANADA
                        //cosa.transform.position, // DESDE DENTRO DE CADA CAJA
                        radioExplosion, alturaExplosion );
            }
        }
	}
}
