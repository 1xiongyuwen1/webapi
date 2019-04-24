/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 13:18:35
*生成者：xiongyuwen
*/
using System;
using SqlSugar;

namespace TopSeller.Core.Entity.Models
{
    ///<summary>
    ///表user_info的实体类
    ///</summary>
    [SugarTable("user_info")]
    public class UserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "user_id")]
        public int UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "user_name")]
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "password")]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "is_lock")]
        public bool IsLock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_date")]
        public System.DateTime CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "modify_date")]
        public System.DateTime ModifyDate { get; set; }
    }
}