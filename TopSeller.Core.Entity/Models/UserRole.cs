/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 13:19:18
*生成者：xiongyuwen
*/
using System;
using SqlSugar;

namespace TopSeller.Core.Entity.Models
{
    ///<summary>
    ///表user_role的实体类
    ///</summary>
    [SugarTable("user_role")]
    public class UserRole
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "role_id")]
        public int? RoleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "user_id")]
        public int? UserId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_id")]
        public int? CreateId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_user")]
        public string CreateUser { get; set; }
    }
}