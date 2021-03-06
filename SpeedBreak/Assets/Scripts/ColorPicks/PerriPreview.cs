using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerriPreview : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject perriSpot;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        gameManager.PerriPreview();
        perriSpot.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        perriSpot.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameManager.CarPerriwinkle();
        perriSpot.gameObject.SetActive(false);
    }
}
