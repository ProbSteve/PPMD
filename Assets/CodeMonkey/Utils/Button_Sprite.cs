/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading the Code Monkey Utilities
    I hope you find them useful in your projects
    If you have any questions use the contact form
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */
 
//#define SOUND_MANAGER // Has Sound_Manager in project
//#define CURSOR_MANAGER // Has Cursor_Manager in project

using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace CodeMonkey.Utils
{

    /*
     * Button Actions on a World BoxCollider
     * */
    public class Button_Sprite : MonoBehaviour
    {

        private static Func<Camera> GetWorldCamera;

        public static void SetGetWorldCamera(Func<Camera> GetWorldCamera)
        {
            Button_Sprite.GetWorldCamera = GetWorldCamera;
        }





        public Action ClickFunc = null;
        public Action MouseRightDownOnceFunc = null;
        public Action MouseRightDownFunc = null;
        public Action MouseRightUpFunc = null;
        public Action MouseDownOnceFunc = null;
        public Action MouseUpOnceFunc = null;
        public Action MouseOverOnceFunc = null;
        public Action MouseOutOnceFunc = null;
        public Action MouseOverOnceTooltipFunc = null;
        public Action MouseOutOnceTooltipFunc = null;

        private bool draggingMouseRight;
        private Vector3 mouseRightDragStart;
        public Action<Vector3, Vector3> MouseRightDragFunc = null;
        public Action<Vector3, Vector3> MouseRightDragUpdateFunc = null;
        public bool triggerMouseRightDragOnEnter = false;

        public enum HoverBehaviour
        {
            Custom,
            Change_Color,
            Change_Image,
            Change_SetActive,
        }
        public HoverBehaviour hoverBehaviourType = HoverBehaviour.Custom;
        private Action hoverBehaviourFunc_Enter, hoverBehaviourFunc_Exit;

        public Color hoverBehaviour_Color_Enter = new Color(1, 1, 1, 1), hoverBehaviour_Color_Exit = new Color(1, 1, 1, 1);
        public SpriteRenderer hoverBehaviour_Image;
        public Sprite hoverBehaviour_Sprite_Exit, hoverBehaviour_Sprite_Enter;
        public bool hoverBehaviour_Move = false;
        public Vector2 hoverBehaviour_Move_Amount = Vector2.zero;
        private Vector3 posExit, posEnter;
        public bool triggerMouseOutFuncOnClick = false;
        public bool clickThroughUI = false;
    }
}

   