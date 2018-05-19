using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using UTP.Const;

namespace UTP.Parts
{
    public class ButtonUI : MonoBehaviour
    {
        public Button _button;
        public Text _text;

        /// <summary>
        /// ボタンの初期化処理
        /// </summary>
        public void InitButton(Dictionary<string, object> param)
        {
            _text.text = (string)param[ConstParamName.KEY_BUTTON_TEXT];
            long id = (long)param[ConstParamName.KEY_BUTTON_ID];
            _button.OnClickAsObservable().Subscribe(_ => ButtonProcess(id)).AddTo(this.gameObject);
        }

        /// <summary>
        /// ボタンの処理
        /// </summary>
        private void ButtonProcess(long id)
        {
            Debug.Log("" + id);
        }
    }
}