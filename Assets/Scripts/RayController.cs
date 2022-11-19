using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour
{
    public float range = 20f;
    public float force = 4;
    public GameObject effect;

    public AudioSource controlSonido;
    public AudioClip SonidoDisparo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range))
            {
                Debug.Log(hit.collider.name);
                GameObject _effect = Instantiate(effect, hit.point, Quaternion.identity);
                Destroy(_effect, 0.8f);

                controlSonido.PlayOneShot(SonidoDisparo);

                //Para darle efecto de fuerza cuando choca con algo la bala
                if(hit.collider.GetComponent<Rigidbody>() != null)
                {
                    hit.collider.GetComponent<Rigidbody>().AddForce(hit.normal * force);
                }
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(Camera.main.transform.position, Camera.main.transform.forward* range);
    }
}
