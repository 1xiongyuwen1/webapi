/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 13:15:39
*生成者：xiongyuwen
*/
using System;
using SqlSugar;

namespace TopSeller.Core.Entity.Models
{
    ///<summary>
    ///表permission的实体类
    ///</summary>
    [SugarTable("permission")]
    public class Permission
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "url_path")]
        public string UrlPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "url_name")]
        public string UrlName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "is_button")]
        public bool? IsButton { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "pid")]
        public int? Pid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "module_id")]
        public int? ModuleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "order_sort")]
        public int? OrderSort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "enable")]
        public bool? Enable { get; set; }
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