using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    namespace Input
    {
        public class ButtonManager : MonoBehaviour
        {
            #region Variables
            //  子コンポーネントを格納
            private UIImage uiimage;                    //  子オブジェクト「Image」用
            private UIText uitext;                      //  子オブジェクト「Text」用

            //  初期化をおこなったか
            [SerializeField] private bool init = false;

            #region Image   子Imageの管理
            //  子オブジェクト「Image」のデータ管理

            [SerializeField] private Sprite image;  //  変更用画像データを格納

            #endregion

            #region Text    子Textの管理
            //  子オブジェクト「Text」のデータ管理

            [TextArea(3, 10)]
            [SerializeField] private string text;   //  変更用テキストデータを格納
            [SerializeField] private int size;      //  変換用フォントサイズデータを格納

            #endregion

            private Transform trans;

            private Transform transChild;

            #endregion

            private void Start()
            {
                transChild.GetChild(0).gameObject.SetActive(false);
            }

            public void Initialize()
            {
                trans = this.gameObject.transform;
                //transChild = trans.GetChild(0).gameObject.transform;
                //  子コンポーネントを取得
                uiimage = trans.GetChild(1).GetComponent<UIImage>();
                uitext = trans.GetChild(2).GetComponent<UIText>();
                init = true;
            }

            public void OnValidate()
            {
                Initialize();
                uiimage.Sprite = image;
                uitext.Text = text;
                uitext.Size = size;
                uiimage.SetImage();
                uitext.Change();
            }
        }
    }
}
