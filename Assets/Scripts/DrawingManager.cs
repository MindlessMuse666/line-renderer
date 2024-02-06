using UnityEngine;

public class DrawingManager : MonoBehaviour
{
    [SerializeField] private float _deep = 10;
    
    private LineRenderer _lineRenderer;
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
        _lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        Draw();
    }

    private void Draw()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lineRenderer.positionCount = 0;
        }

        if (Input.GetMouseButton(0))
        {
            var mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _deep);
            var drawingPoint = _camera.ScreenToWorldPoint(mousePosition);
            _lineRenderer.positionCount++;
            _lineRenderer.SetPosition(_lineRenderer.positionCount - 1, drawingPoint);
        }
    }
}