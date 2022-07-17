using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class CursorFollow : MonoSingleton<CursorFollow>
{
    Canvas canvas;
    RectTransform rectTransform;
    Vector2 pos;
    Camera _camera;
    RectTransform canvasRectTransform;
    Color initialColor;
    public GameObject description;
    public GameObject extraDis;
    public Image image;
    public Text text;
    public Text extraText;
    public bool isOnUI;

    private string 反击 = "反击：回合末第一次攻击伤害 = 初始伤害 + 反击层数*本回合受到所有伤害的20%";
    private string 恐惧 = "恐惧：受到的伤害增加30%";
    private string 眩晕 = "眩晕：停止行动";
    private string 灼伤 = "灼伤：每回合受到10点伤害，无视护甲";
    private string 束缚 = "束缚：玩家抽牌数减少1";
    private string 吞噬 = "吞噬：消灭目标并累加吞噬目标一半的生命值和攻击力";
    void Start()
    {
        
        description = transform.GetChild(0).gameObject;
        initialColor = description.GetComponent<Image>().color;
        description.SetActive(false);
        extraText = extraDis.transform.GetChild(0).GetComponent<Text>();
        transform.GetChild(0).gameObject.SetActive(false);
        Cursor.visible = false;
        rectTransform = transform as RectTransform;
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        _camera = canvas.GetComponent<Camera>();
        canvasRectTransform = canvas.transform as RectTransform;
        Debug.Log(canvas.renderMode);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            image.gameObject.transform.DOPunchRotation(new Vector3(0, 0, 20), 0.1f, 1, 1);
        }
        FollowMouseMove();
        isOnUI = GetOverUI(canvas);
        if (isOnUI==false)
        {
            text.text = null;
            description.GetComponent<Image>().color = initialColor;
            description.SetActive(false);
            extraDis.SetActive(false);
        }
        if (isOnUI == true)
        {
            CheckText();
        }
        transform.SetAsLastSibling();
        
    }
    public void CheckText()
    {       
        if (text.text.Contains("反击"))
        {
            extraDis.SetActive(true);
            extraText.text = 反击;
        }
        if (text.text.Contains("吞噬"))
        {
            extraDis.SetActive(true);
            extraText.text = 吞噬;
        }
        if (text.text.Contains("灼伤"))
        {
            extraDis.SetActive(true);
            extraText.text = 灼伤;
        }
        if (text.text.Contains("束缚"))
        {
            extraDis.SetActive(true);
            extraText.text = 束缚;
        }
        if (text.text.Contains("眩晕") && !text.text.Contains("恐惧"))
        {
            extraDis.SetActive(true);
            extraText.text = 眩晕;
        }
        if (text.text.Contains("恐惧") && !text.text.Contains("眩晕"))
        {
            extraDis.SetActive(true);
            extraText.text = 恐惧;
        }
        if (text.text.Contains("眩晕") && text.text.Contains("恐惧"))
        {
            extraDis.SetActive(true);
            extraText.text = 眩晕 + "\n\n" + 恐惧;
        }
        if (!text.text.Contains("反击") && !text.text.Contains("恐惧") && !text.text.Contains("眩晕")&&!text.text.Contains("灼伤")&&!text.text.Contains("束缚")&&!text.text.Contains("吞噬"))
        {
            extraDis.SetActive(false);
        }
    }
    public void FollowMouseMove()
    {
        //worldCamera:1.screenSpace-Camera 
        // canvas.GetComponent<Camera>() 1.ScreenSpace -Overlay 
        if (RenderMode.ScreenSpaceCamera == canvas.renderMode)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, Input.mousePosition, canvas.worldCamera, out pos);
        }
        else if (RenderMode.ScreenSpaceOverlay == canvas.renderMode)
        {
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, Input.mousePosition, _camera, out pos);
        }
        else
        {
            Debug.Log("请选择正确的相机模式!");
        }
        rectTransform.anchoredPosition = pos;

        //或者

        //transform.localPosition = new Vector3(pos.x, pos.y, 0);
    }
    public GameObject GetOverUI(Canvas canvas)
    {
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current);
        pointerEventData.position = Input.mousePosition;
        GraphicRaycaster gr = canvas.GetComponent<GraphicRaycaster>();
        List<RaycastResult> results = new List<RaycastResult>();
        gr.Raycast(pointerEventData, results);
        if (results.Count != 0)
        {
            return results[0].gameObject;
        }

        return null;
    }
}


