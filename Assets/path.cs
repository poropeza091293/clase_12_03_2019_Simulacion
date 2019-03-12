using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    public GameObject ini;
    public GameObject fini;

    public GameObject[] EncontrarCamino(GameObject inicial, GameObject final)
    {
        GameObject[] aux;

        aux = new GameObject[50];

        GameObject pivote;

        pivote = inicial;

        int ind = 0;

        aux[ind++] = pivote;

        

        while (pivote.name!= "Sphere")
        {
            float mas_cercano_al_final = 99999999999999999999f;
            int ind_mas_cercano = 0;

            for (int eee = 0; eee < pivote.GetComponent<nodo>().lista_vecinos.Length; eee++)
            {
                if (pivote.GetComponent<nodo>().lista_vecinos[eee] != null)//ya puedo hacer comparaciones
                {
                    if (Vector3.Distance(pivote.GetComponent<nodo>().lista_vecinos[eee].transform.position, final.transform.position) < mas_cercano_al_final)
                    {
                        mas_cercano_al_final = Vector3.Distance(pivote.GetComponent<nodo>().lista_vecinos[eee].transform.position, final.transform.position);
                        ind_mas_cercano = eee;
                    }
                }
                else
                {
                    break;
                }
            }

            pivote = pivote.GetComponent<nodo>().lista_vecinos[ind_mas_cercano];

            //Debug.Log(ind);

            aux[ind++] = pivote;
        }



        return aux;
 
    }
        
	// Use this for initialization
	void Start ()
    {
        GameObject[] ruta;
        float sum = 0;

        ruta = this.EncontrarCamino(ini, fini);

        for (int i = 0; i < ruta.Length; i++)
        {
            if (ruta[i] != null)
            {
                Debug.Log(ruta[i].name);

                if (ruta[i + 1] != null)
                {
                    sum = sum + Vector3.Distance(ruta[i].transform.position, ruta[i + 1].transform.position);
                }
                
            }
            else
            {
                break;
            }
        }

        Debug.Log("Sumatoria: " + sum);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
