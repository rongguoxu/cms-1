﻿using SS.CMS.Data;

namespace SS.CMS.Abstractions
{
    /// <summary>
    /// 插件运行环境接口。
    /// </summary>
    public interface IEnvironment
    {
        /// <summary>
        /// 系统使用的数据库类型。
        /// </summary>
        IDb Db { get; }

        /// <summary>
        /// 用户中心文件夹名称。
        /// </summary>
        string HomeDirectory { get; }

        /// <summary>
        /// 管理后台文件夹名称。
        /// </summary>
        string AdminDirectory { get; }

        string ContentRootPath { get; }

        string WebRootPath { get; }

        /// <summary>
        /// 网站根目录访问地址。
        /// </summary>
        string ApplicationPath { get; }

        /// <summary>
        /// API访问地址。
        /// </summary>
        string ApiUrl { get; }
    }
}