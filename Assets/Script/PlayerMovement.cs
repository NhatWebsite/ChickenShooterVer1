using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    // Update is called once per frame
   private RectTransform rectTransform;
    private Canvas canvas;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    void Update()
    {
        // Lấy vị trí của chuột trong không gian màn hình
        Vector2 mousePosition = Input.mousePosition;

        // Chuyển đổi vị trí của chuột từ không gian màn hình sang không gian thế giới
        Vector2 anchoredPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, mousePosition, canvas.worldCamera, out anchoredPosition);

        // Cập nhật vị trí của RectTransform theo vị trí chuột
        rectTransform.anchoredPosition = anchoredPosition;
    }

}
