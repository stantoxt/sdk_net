﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfoPlus.ApplicationToolkit.Entities
{
    public class FormInstance
    {
        public string InstanceId { get; set; }			// 表单实例Id
        public string InstanceName { get; set; }		// 表单实例标题
        public string BusinessId { get; set; }			// 启动实例时的businessId
        public long EntryId { get; set; }			    // 流水号
        public InfoPlusUser Creator { get; set; }		// 创建人[1]，创建此表单实例的用户
        public InfoPlusUser Owner { get; set; }			// 所有者[2]，可能会与创建人不同
        public long CreateTime { get; set; }			// 创建时间
        public long LastUpdate { get; set; }			// 最后更新时间
        // 实例状态：-1->未知,0->已创建，1->进行中，2->挂起，3->已中止，4->已完成
        public int State { get; set; }
        public int Priority { get; set; }               // 优先级
        public string Tags { get; set; }                // Tags

    }
}