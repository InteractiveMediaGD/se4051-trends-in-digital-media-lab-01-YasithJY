using UnityEngine;

public class GazeInteractionC3 : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color originalColor;

    public Color gazeColor = Color.green;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == transform)
            {
                objectRenderer.material.color = gazeColor;
            }
            else
            {
                objectRenderer.material.color = originalColor;
            }
        }
        else
        {
            objectRenderer.material.color = originalColor;
        }
    }
}