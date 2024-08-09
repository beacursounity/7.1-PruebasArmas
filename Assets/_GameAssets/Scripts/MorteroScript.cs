using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteroScript : MonoBehaviour {

    [SerializeField] Transform genPoint;
    [SerializeField] GameObject prefabProyectil;
    //[SerializeField] GameObject hitParticles;
    [SerializeField] int force = 600;

    AudioSource audioSource;
    //[SerializeField] LineRenderer balaTrail;
    

    //public float range = 100f; // MAXIMO RANGO ARMA
    //float spreadfactor = 0.1f;

    //RaycastHit hit;

	// Use this for initialization
	void Start () {
        // RECOGER EL SONIDO
        audioSource = GetComponent<AudioSource>();	
	}

    private void FixedUpdate()
    {
        //Physics.Raycast(genPoint.transform.position, proyectil.transform.forward,
         ///       out hit);
    }

    /*void GeneracionTrailBalas (Vector3 puntoGolpe) {
        GameObject efectoTrailBala = Instantiate(balaTrail.gameObject,
            genPoint.transform.position, Quaternion.identity);

        LineRenderer lineaR = efectoTrailBala.GetComponent<LineRenderer>();
        lineaR.SetPosition(0, genPoint.transform.position);
        lineaR.SetPosition(1, puntoGolpe);

        Destroy(efectoTrailBala,1f);
	}*/

    // cuando pulsemos con el raton encima de nuestro Mortero disparara
    private void OnMouseDown() {
        GameObject proyectil = Instantiate(prefabProyectil,
                                genPoint.transform.position,
                                genPoint.transform.rotation);

        //LE AÑADIMOS LA FUERZA
        proyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force);
        // SONIDO
        audioSource.Play();

        /*Vector3 direccion = genPoint.transform.forward;
        direccion = direccion + genPoint.TransformDirection
                (new Vector3(Random.Range(-spreadfactor, spreadfactor),
                Random.Range(-spreadfactor, spreadfactor)));

        if (Physics.Raycast(genPoint.position, direccion,
                out hit , range)){
            print("Ha pasado");
            GameObject hitParticleEffect = Instantiate(hitParticles, hit.point,
                Quaternion.FromToRotation(Vector3.up, hit.normal));

           // GameObject bullImpact = Instantiate();
        }

        GeneracionTrailBalas(hit.point);*/

        // DESTRUIMOS EL PROYECTIL
       // Invoke("Destruir", 2);
    }

    private void Detruir() {
        //Destroy(prefabProyectil);
    }
}
