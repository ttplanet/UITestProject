using System.Collections.Generic;
using UnityEngine;
using UTP.Const;
using UTP.Parts;
using UTP.User.Data;

namespace UTP.Program
{
    public class UITester : MonoBehaviour
    {
        public Transform parentTransform;

        public static UserData _userData = new UserData(3);

        private void Start()
        {
            //実際に回す部分
            for (int i = 0; i < _userData.TotalButton; i++)
            {
                CreateButton(i);
            }
        }

        private void CreateButton(int index)
        {
            GameObject buttonprefab = Resources.Load<GameObject>(ConstPath.PATH_PARTS_BUTTON);
            GameObject buttonObject =
                (GameObject)Instantiate(buttonprefab, buttonprefab.transform.position, buttonprefab.transform.rotation, parentTransform);
            ButtonUI buttonUI = buttonObject.GetComponent<ButtonUI>();
            Dictionary<string, object> param = new Dictionary<string, object>
            {
                {ConstParamName.KEY_BUTTON_TEXT,_userData.TextData[index].Name },
                {ConstParamName.KEY_BUTTON_ID,_userData.TextData[index].Id }
            };
            buttonUI.InitButton(param);//ボタンの初期化
        }
    }
}