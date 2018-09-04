﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Models
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 是否删除false末 true已删除
        /// </summary>
        [Display(Name = "是否启用")]
        public bool IsDelete { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
          [Display(Name = "备注")]
        public string Description { get; set; }
        /// <summary>
        /// 时间戳
        /// </summary>
        [Timestamp]
        [ConcurrencyCheck]
        public byte[] TimestampV { get; set; }
    }
}
