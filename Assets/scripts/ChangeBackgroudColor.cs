using UnityEngine;

public class ChangeBackgroudColor : MonoBehaviour
{
    private Camera cam;
    private bool cycleColors = false;
    private float elapsedTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (cycleColors && elapsedTime > 1)
        {
            ChangeColor();
            elapsedTime = 0;
        }
    }

    public void ChangeColor()
    {
        cam.backgroundColor = Random.ColorHSV();
    }

    public void ToggleCycleColors()
    {
        cycleColors = !cycleColors;
    }
}
