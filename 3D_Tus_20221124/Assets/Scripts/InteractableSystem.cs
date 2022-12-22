using UnityEngine;

namespace FOX
{
    /// <summary>
    /// 互動系統:偵測玩家是否進入並且執行互動行為
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

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
                dialogueSystem.StartDialogue(dataDialogue);
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
    }
}