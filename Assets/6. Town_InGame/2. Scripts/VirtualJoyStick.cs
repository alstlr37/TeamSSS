using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualJoyStick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public RectTransform Joy2;

    [SerializeField]
    private RectTransform lever;
    private RectTransform rectTransform;

    [SerializeField, Range(10, 1000)]
    private float leverRange;

    private Vector2 inputDirection;
    private bool isInput;

    [SerializeField]
    private PlayerController controller;

    public float sensitivity = 1f;

    public enum JoyStickType { Move, Rotate }
    public JoyStickType joystickType;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        switch (joystickType)
        {
            case JoyStickType.Move:
                ControlJoyStickLever(eventData);
                isInput = true;
                break;
            case JoyStickType.Rotate:
                //GameObject.Find("Joy2").transform.Translate(new Vector3(0, 0, 0));
                Joy2.transform.position = new Vector2(eventData.position.x, eventData.position.y);
                ControlJoyStickLever(eventData);
                isInput = true;
                break;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        ControlJoyStickLever(eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.anchoredPosition = Vector2.zero;
        isInput = false;
        switch (joystickType)
        {
            case JoyStickType.Move:
                controller.Move(Vector2.zero);
                break;
            case JoyStickType.Rotate:
                break;
        }
    }

    private void ControlJoyStickLever(PointerEventData eventData)
    {
        var inputPos = eventData.position - rectTransform.anchoredPosition;
        var inputVector = inputPos.magnitude < leverRange ? inputPos : inputPos.normalized * leverRange;
        lever.anchoredPosition = inputVector;
        inputDirection = inputVector / leverRange;
    }

    private void InputControlVector()
    {
        switch(joystickType)
        {
            case JoyStickType.Move:
                controller.Move(inputDirection * sensitivity);
                break;
            case JoyStickType.Rotate:
                controller.LookAround(inputDirection * sensitivity);
                break;
        }
        // 캐릭터에게 입력벡터를 전달
        //Debug.Log(inputDirection.x + " / " + inputDirection.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInput)
        {
            InputControlVector();
        }
    }
}
