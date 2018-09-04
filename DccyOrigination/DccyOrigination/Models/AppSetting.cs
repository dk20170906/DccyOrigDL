using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Models
{
    public class AppSetting
    {
        private string encryptKey;
        /// <summary>
        /// 密码加密密钥
        /// </summary>
        public string EncryptKey
        {
            get
            {
                if (encryptKey == null || encryptKey.Length % 16 != 0)
                {
                    encryptKey = "23456789QWERTYIOPLKJHGFSAZXCVBNM";
                }
                return encryptKey;
            }
            set
            {
                encryptKey = value;
            }
        }

    }
}
