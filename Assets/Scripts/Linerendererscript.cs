using UnityEngine;

public class Linerendererscript : MonoBehaviour
{
    [SerializeField] private Transform position2;
    [SerializeField] private LineRenderer lineRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lineRenderer.SetPosition(0, position2.position);
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, position2.position);
    }
}
