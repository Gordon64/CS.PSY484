using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempCubeColorChanger : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    private Renderer cubeRenderer;

    private Color newCubeColor;

    private float randomOne, randomTwo, randomThree;

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Button Pressed");
            randomOne = Random.Range(0f, 1f);
            randomTwo = Random.Range(0f, 1f);
            randomThree = Random.Range(0f, 1f);

            newCubeColor = new Color(randomOne, randomTwo, randomThree, 1f);

            cubeRenderer.material.SetColor("_Color", newCubeColor);
        }
    }
}
