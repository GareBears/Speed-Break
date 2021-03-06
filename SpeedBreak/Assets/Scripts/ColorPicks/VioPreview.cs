using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VioPreview : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject vioSpot;

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
        gameManager.VioPreview();
        vioSpot.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        vioSpot.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        gameManager.CarViolet();
        vioSpot.gameObject.SetActive(false);
    }
}
