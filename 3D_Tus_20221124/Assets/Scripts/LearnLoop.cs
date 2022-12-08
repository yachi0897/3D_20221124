
using UnityEngine;


namespace FOX
{
    /// <summary>
    /// 認識迴圈:重複執行程式
    ///for ,while, do while ,foreach 
    /// </summary>

public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            //for 迴圈語法:
            //for (初始值 ； 布林值 條件 :迴圈結束執行區域){程式區塊}
            for (int i = 0; i < 10; i++)
            {
                print("for 迴圈內容:" + i);
            }


            for ( int number =0; number <5; number++)
            {
                print("迴圈:" + number);
            }
        }







    }
}