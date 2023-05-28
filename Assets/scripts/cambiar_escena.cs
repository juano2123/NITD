using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiar_escena : MonoBehaviour
{
    // Start is called before the first frame update
    public new GameObject collider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(EsperarYCambiarEscena());
        }
    }

    IEnumerator EsperarYCambiarEscena()
    {
        yield return new WaitForSeconds(1.5f); // Esperar 2 segundos

        SceneManager.LoadScene("Scenes/Map_Hosp1"); // Cambiar escena
    }
}