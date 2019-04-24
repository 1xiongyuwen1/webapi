/*
*本代码由生成器自动生成，一般情况不需要更改。
*生成时间：2019/4/23 13:17:37
*生成者：xiongyuwen
*/
using System;
using SqlSugar;

namespace TopSeller.Core.Entity.Models
{
    ///<summary>
    ///表role的实体类
    ///</summary>
    [SugarTable("role")]
    public class Role
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "id")]
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "name")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "description")]
        public string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "order_sort")]
        public int? OrderSort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "enabled")]
        public bool? Enabled { get; set; }
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
    }
}