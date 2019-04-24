/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 13:18:03
*生成者：xiongyuwen
*/
using System;
using SqlSugar;

namespace TopSeller.Core.Entity.Models
{
    ///<summary>
    ///表role_module_permission的实体类
    ///</summary>
    [SugarTable("role_module_permission")]
    public class RoleModulePermission
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
        [SugarColumn(ColumnName = "module_id")]
        public int? ModuleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "permission_id")]
        public int? PermissionId { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_date")]
        public System.DateTime? CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "modify_date")]
        public System.DateTime? ModifyDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "modify_user_id")]
        public string ModifyUserId { get; set; }

        // 下边三个实体参数，只是做传参作用，所以忽略下
        [SugarColumn(IsIgnore = true)]
        public Role Role { get; set; }
        [SugarColumn(IsIgnore = true)]
        public MenuModule Module { get; set; }
        [SugarColumn(IsIgnore = true)]
        public Permission Permission { get; set; }
    }
}