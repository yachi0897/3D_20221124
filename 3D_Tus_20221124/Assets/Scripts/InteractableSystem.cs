using UnityEngine;
using UnityEngine.Events;

namespace FOX
{
    /// <summary>
    /// 互動系統:偵測玩家是否進入並且執行互動行為
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;
        [SerializeField, Header("對話結束後的事件")]
        private UnityEvent onDialogueFinish;
        [SerializeField, Header("啟動道具")]
        private GameObject propActive;
        [SerializeField,Header("啟動後的對話資料")]
        private DialogueData dataDialogueActive;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("畫布對話系統").GetComponent<DialogueSystem>();
        }


        ///3D物件適用
        //兩個碰撞物件必須其中一個勾選Is Trigger
        //碰撞開始
        private void OnTriggerEnter(Collider other)
        {
            //如果 碰撞物件名稱 包含 PlayerCapsule 就執行{}
            if (other.name.Contains(nameTarget))
            {
                print(other.name);
                //如果不需要啟動道具 或者 啟動道具是顯示的 就執行 第一段對話
                if (propActive == null || propActive.activeInHierarchy)
                {
                    dialogueSystem.StartDialogue(dataDialogue, onDialogueFinish);
                }
                else
                {
                    dialogueSystem.StartDialogue(dataDialogueActive);
                }
            }


        }
        //碰撞結束
        private void OnTriggerExit(Collider other)
        {

        }
        //碰撞持續
        private void OnTriggerStay(Collider other)
        {

        }

        ///<summary>
        ///隱藏物件
        ///</summary>
        public void HiddenObject()
        {
            gameObject.SetActive(false);
        }









    }


}