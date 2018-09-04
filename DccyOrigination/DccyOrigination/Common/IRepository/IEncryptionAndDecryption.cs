using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace DccyOrigination.Common.IRepository
{
   public interface IEncryptionAndDecryption
    {
        #region 生成RSA密钥
        ///// <summary>
        ///// 生成RSA密钥
        ///// </summary>
        ///// <returns></returns>
        RSAParameters GenerateKey();
        #endregion

        #region MD5 加密
        /// <summary>
        /// MD5 加密方法
        /// </summary>
        /// <param name="EncryptString">待加密的密文</param>
        /// <returns>returns</returns>
        string MD5Encrypt(string EncryptString);


        #endregion

        #region DES 加密解密
        /// <summary>
        /// DES 加密(数据加密标准，速度较快，适用于加密大量数据的场合)
        /// </summary>
        /// <param name="EncryptString">待加密的密文</param>
        /// <param name="EncryptKey">加密的密钥</param>
        /// <returns>returns</returns>
        string DESEncrypt(string EncryptString, string EncryptKey);
        /// <summary>
        /// DES 解密(数据加密标准，速度较快，适用于加密大量数据的场合)
        /// </summary>
        /// <param name="DecryptString">待解密的密文</param>
        /// <param name="DecryptKey">解密的密钥</param>
        /// <returns>returns</returns>
        string DESDecrypt(string DecryptString, string DecryptKey);
        #endregion

        #region  RC2 加密解密
        /// <summary>
        /// RC2 加密(用变长密钥对大量数据进行加密)
        /// </summary>
        /// <param name="EncryptString">待加密密文</param>
        /// <param name="EncryptKey">加密密钥</param>
        /// <returns>returns</returns>
        string RC2Encrypt(string EncryptString, string EncryptKey);
        /// <summary>
        /// RC2 解密(用变长密钥对大量数据进行加密)
        /// </summary>
        /// <param name="DecryptString">待解密密文</param>
        /// <param name="DecryptKey">解密密钥</param>
        /// <returns>returns</returns>
        string RC2Decrypt(string DecryptString, string DecryptKey);
        #endregion

        #region 3DES 加密解密
        /// <summary>
        /// 3DES 加密(基于DES，对一块数据用三个不同的密钥进行三次加密，强度更高)
        /// </summary>
        /// <param name="EncryptString">待加密密文</param>
        /// <param name="EncryptKey1">密钥一</param>
        /// <param name="EncryptKey2">密钥二</param>
        /// <param name="EncryptKey3">密钥三</param>
        /// <returns>returns</returns>
        string DES3Encrypt(string EncryptString, string EncryptKey1, string EncryptKey2, string EncryptKey3);
        /// <summary>
        /// 3DES 解密(基于DES，对一块数据用三个不同的密钥进行三次加密，强度更高)
        /// </summary>
        /// <param name="DecryptString">待解密密文</param>
        /// <param name="DecryptKey1">密钥一</param>
        /// <param name="DecryptKey2">密钥二</param>
        /// <param name="DecryptKey3">密钥三</param>
        /// <returns>returns</returns>
        string DES3Decrypt(string DecryptString, string DecryptKey1, string DecryptKey2, string DecryptKey3);
        #endregion

        #region AES加密解密
        /// <summary>
        /// AES 加密(高级加密标准，是下一代的加密算法标准，速度快，安全级别高，目前 AES 标准的一个实现是 Rijndael 算法)
        /// </summary>
        /// <param name="EncryptString">待加密密文</param>
        /// <param name="EncryptKey">加密密钥</param>
        /// <returns></returns>
        string AESEncrypt(string EncryptString, string EncryptKey);
        /// <summary>
        /// AES 解密(高级加密标准，是下一代的加密算法标准，速度快，安全级别高，目前 AES 标准的一个实现是 Rijndael 算法)
        /// </summary>
        /// <param name="DecryptString">待解密密文</param>
        /// <param name="DecryptKey">解密密钥</param>
        /// <returns></returns>
        string AESDecrypt(string DecryptString, string DecryptKey);
        #endregion

        #region 1、方法一
        /// <summary>
        /// 1、方法一 (不可逆加密
        /// </summary>
        /// <param name="PasswordString"></param>
        /// <param name="PasswordFormat"></param>
        /// <returns></returns>
        //public string EncryptPassword(string PasswordString, string PasswordFormat)
        //{
        //    string encryptPassword = null;
        //    if (PasswordFormat == "SHA1")
        //    {
        //    //encryptPassword = FormsAuthortication.HashPasswordForStoringInConfigFile(PasswordString, "SHA1");
        //    encryptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(PasswordString, "SHA1");
        //    }
        //    else if (PasswordFormat == "MD5")
        //    {
        //        //encryptPassword =  FormsAuthortication.HashPasswordForStoringInConfigFile(PasswordString, "MD5");
        //        encryptPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(PasswordString, "MD5");
        //    }
        //    return encryptPassword;
        //}
        #endregion

        #region 2、方法二 (可逆加密)

        //加密
        string encode(string str);
        //解密
        string decode(string str);

        #endregion

        #region 3、方法三 (可逆加密)

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="data">待加密的数据字符</param>
        /// <returns></returns>
        string Encode(string data);

        /// 解密
        /// </summary>
        /// <param name="data">待解密的数据字符</param>
        /// <returns></returns>
        string Decode(string data);

        #endregion

        #region 4、方法四 MD5不可逆加密 (32位加密)
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="s"></param>
        /// <param name="_input_charset"></param>
        /// <returns></returns>
        string GetMD5(string s, string _input_charset);

        /// <summary>
        /// MD5加密 (16位加密)
        /// </summary>
        /// <param name="ConvertString"></param>
        /// <returns></returns>
        string GetMd5Str(string ConvertString);

        #endregion

        #region 5、方法五 加密解密文本文件

        /// <summary>
        /// 加密文件
        /// </summary>
        /// <param name="inName"></param>
        /// <param name="outName"></param>
        /// <param name="desKey"></param>
        /// <param name="desIV"></param>
        void EncryptData(String inName, String outName, byte[] desKey, byte[] desIV);
        /// <summary>
        /// 解密文件
        /// </summary>
        /// <param name="inName"></param>
        /// <param name="outName"></param>
        /// <param name="desKey"></param>
        /// <param name="desIV"></param>
        void DecryptData(String inName, String outName, byte[] desKey, byte[] desIV);

        #endregion

        #region 6、方法六 DES加密解密

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        string EncryptDES(string encryptString, string encryptKey);
        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        string DecryptDES(string decryptString, string decryptKey);
        #endregion
    }
}
