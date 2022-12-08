using UnityEngine;
using TMPro;
using System.Collections;


namespace FOX
{

    /// <summary>
    /// 對話系統
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        [SerializeField, Header("對話間隔"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;
        [SerializeField, Header("開頭對話")]
        private DialogueData dialogueOpening;


        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);

        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContent;
        private GameObject goTriangle;
        #region
        private void Awake()
        {
            groupDialogue = GameObject.Find("畫布對話系統").GetComponent<CanvasGroup>();
            textName = GameObject.Find("對話者名稱").GetComponent<TextMeshProUGUI>();
            textContent = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("對話完成圖示");
            goTriangle.SetActive(false);

            StartCoroutine(FadeGroup());
            StartCoroutine(TypeEffect());
        }
#endregion




        ///<summary>
        ///淡入淡出群組物件
        ///</summary>
        private IEnumerator FadeGroup()
        {
            for (int i =0; i<10; i++)
            {
                groupDialogue.alpha += 0.1f;
                yield return new WaitForSeconds(0.04f);
            }
        }

        private IEnumerator TypeEffect()
        {
            textName.text = dialogueOpening.dialogueName;
            textContent.text = "";

            string dialogue = dialogueOpening.dialogueContents[0];
         yield return dialogueInterval;

        }
    }


}