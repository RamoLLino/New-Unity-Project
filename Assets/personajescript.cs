using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class personajescript : MonoBehaviour
{

    public int nivelhambre;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Tomaralimento(int valoralimentario)
    {
        nivelhambre -= valoralimentario;
        if (nivelhambre <= 0)
        {
            nivelhambre = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        alimentoscript alimento;
        alimento = other.GetComponent<alimentoscript>();
        if (alimento)
        {
            Tomaralimento(alimento.valoralimentario);
            Destroy(other.gameObject);
        }
    }

}

