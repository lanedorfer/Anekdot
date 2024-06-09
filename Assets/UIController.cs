/*
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private Transform _canvasParrentTransform;
    [SerializeField] private GameObject _uiPopuoMenu;
    private bool _isPause;
    
    void Start()
    {
        GameObject popupMenu = Instantiate(_uiPopuoMenu);
        
        popupMenu.transform.SetParent(_canvasParrentTransform, false);
        RectTransform rectTransform = popupMenu.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = Vector2.zero;
        rectTransform.sizeDelta = new Vector2(500, 400);

        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
*/