﻿//------------------------------------------------------------------------------
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//     Author:Yubao Li
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using OpenAuth.Repository.Core;

namespace OpenAuth.Repository.Domain
{
    /// <summary>
    ///
    /// </summary>
    [Table("SysPrinterPlan")]
    public class SysPrinterPlan : StringEntity
    {
        public SysPrinterPlan()
        {
            this.Name = "";
            this.CreateUser = "";
            this.SourceSql = "";
            this.CloumnView = "";
            this.PlanContent = "";
            this.InParamColumn = "";
            this.GroupBy = "";
            this.CreateTime = DateTime.Now;
            this.Disable = false;
        }

        /// <summary>
        ///方案名称
        /// </summary>
        [Description("方案名称")]
        public string Name { get; set; }

        /// <summary>
        ///创建人
        /// </summary>
        [Description("创建人")]
        public string CreateUser { get; set; }

        /// <summary>
        ///数据源;打印方案对应的数据来源SQL
        /// </summary>
        [Description("数据源;打印方案对应的数据来源SQL")]
        public string SourceSql { get; set; }

        /// <summary>
        ///中文视图名;设计打印方案时，提供中文快捷按钮的视图来源
        /// </summary>
        [Description("中文视图名;设计打印方案时，提供中文快捷按钮的视图来源")]
        public string CloumnView { get; set; }
        
        /// <summary>
        ///入口参数字段;入库参数字段数组，通过,分隔
        /// </summary>
        [Description("入口参数字段;入库参数字段数组，通过,分隔")]
        public string InParamColumn { get; set; }
        
        /// <summary>
        ///分组字段，通常用于主从表结构打印时
        /// </summary>
        [Description("分组字段，通常用于主从表结构打印时")]
        public string GroupBy { get; set; }

        /// <summary>
        ///打印方案内容;打印方案JSON对象
        /// </summary>
        [Description("打印方案内容;打印方案JSON对象")]
        public string PlanContent { get; set; }

        /// <summary>
        ///创建日期
        /// </summary>
        [Description("创建日期")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        ///是否可用
        /// </summary>
        [Description("是否可用")]
        public bool Disable { get; set; }
    }
}