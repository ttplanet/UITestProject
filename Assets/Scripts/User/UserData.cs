using System.Collections.Generic;

namespace UTP.User.Data
{
    public class UserData
    {
        public UserData(int totalButton)
        {
            TotalButton = totalButton;

            TextData = new List<TextData>();
            //データを作る
            TextData.Add(new TextData(1, "button0"));
            TextData.Add(new TextData(2, "button1"));
            TextData.Add(new TextData(3, "button2"));
        }

        public List<TextData> TextData { get; set; }
        public int TotalButton { get; set; }
    }
}