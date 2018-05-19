using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UTP.User.Data
{
    /// <summary>
    /// ボタンのテキストデータ 
    /// </summary>
    public class TextData
    {
        public TextData(long id,string name)
        {
            Id = id;
            Name = name;
        }
        public long Id { get; set; }
        public string Name { get; set; }
    }
}

