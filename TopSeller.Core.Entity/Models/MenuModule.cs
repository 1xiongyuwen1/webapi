/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 12:38:25
*生成者：xiongyuwen
*/
using System;
using SqlSugar;

namespace TopSeller.Core.Entity.Models
{
    ///<summary>
    ///表menu_module的实体类
    ///</summary>
    [SugarTable("menu_module")]
    public class MenuModule
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "parent_id")]
        public int? ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "link_url")]
        public string LinkUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "Icon")]
        public string Icon { get; set; }
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
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "create_date")]
        public System.DateTime? CreateDate { get; set; }
    }
}