using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Models .SysManagement
{
    [Table("admUser")]
    public class AdmUser:Entity
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public string Guid { get; set; }
        /// <summary>
        /// 用户帐号
        /// </summary>
        [Display(Name ="账号")]
        public string UserAccounts { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name = "账号姓名")]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        [Display(Name = "最近一次登录时间")]
        public DateTime LastLoginTime { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
                [Display(Name = "角色Id")]
        public int RoleId { get; set; }
        /// <summary>
        /// 部门id
        /// </summary>
        [Display(Name = "部门Id")]
        public int DepId { get; set; }
        /// <summary>
        /// 性别 0女1男
        /// </summary>
        [Display(Name = "性别")]
        public int Sex { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Display(Name = "邮箱")]
        public string Email { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        [Display(Name = "电话")]
        public string Tel { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [Display(Name = "地址")]
        public string Address { get; set; }
        /// <summary>
        /// 详细地址
        /// </summary>
        [Display(Name = "详细地址")]
        public string DetailedAddress { get; set; }
        /// <summary>
        /// 登录次数 
        /// </summary>
        [Display(Name = "登录次数")]
        public int NumOfLogins { get; set; }
        /// <summary>
        /// 缩略图
        /// </summary>
        [Display(Name = "用户图片")]
        public string ThumbnailImage { get; set; }
      

    }
}
