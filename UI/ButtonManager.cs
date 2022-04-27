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
            //  �q�R���|�[�l���g���i�[
            private UIImage uiimage;                    //  �q�I�u�W�F�N�g�uImage�v�p
            private UIText uitext;                      //  �q�I�u�W�F�N�g�uText�v�p

            //  �������������Ȃ�����
            [SerializeField] private bool init = false;

            #region Image   �qImage�̊Ǘ�
            //  �q�I�u�W�F�N�g�uImage�v�̃f�[�^�Ǘ�

            [SerializeField] private Sprite image;  //  �ύX�p�摜�f�[�^���i�[

            #endregion

            #region Text    �qText�̊Ǘ�
            //  �q�I�u�W�F�N�g�uText�v�̃f�[�^�Ǘ�

            [TextArea(3, 10)]
            [SerializeField] private string text;   //  �ύX�p�e�L�X�g�f�[�^���i�[
            [SerializeField] private int size;      //  �ϊ��p�t�H���g�T�C�Y�f�[�^���i�[

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
                //  �q�R���|�[�l���g���擾
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
