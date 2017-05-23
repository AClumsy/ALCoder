﻿#region Copyright (C) 2017 AL系列开源项目

/*       
　　	文件功能描述：时间类型扩展表

*　　	创建人： 阿凌
*       创建人Email：513845034@qq.com

　　	修改描述：
*/

#endregion
using System;

namespace AL.Common.Extention
{
    /// <summary>
    /// 时间秒数转化
    /// </summary>
    public static class DateTimeExtention
    {

        /// <summary>
        /// 获取距离 1970-01-01（格林威治时间）的秒数
        /// </summary>
        /// <param name="localTime"></param>
        /// <returns></returns>
        public static long ToUtcSeconds(this DateTime localTime)
        {
            return (long)(localTime.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds;
        }

        /// <summary>
        /// 距离 1970-01-01（格林威治时间）的秒数转换为当前时间
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static DateTime FromUtcSeconds(this long seconds)
        {
            return new DateTime(1970, 1, 1).AddSeconds(seconds).ToLocalTime();
        }


        /// <summary>
        /// 获取距离 1970-01-01（格林威治时间）的秒数
        /// </summary>
        /// <param name="localTime"></param>
        /// <returns></returns>
        public static long ToUtcMilliSeconds(this DateTime localTime)
        {
            return (long)(localTime.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalMilliseconds;
        }

        /// <summary>
        /// 距离 1970-01-01（格林威治时间）的秒数转换为当前时间
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static DateTime FromUtcMilliSeconds(this long seconds)
        {
            return new DateTime(1970, 1, 1).AddMilliseconds(seconds).ToLocalTime();
        }

        /// <summary>
        /// 获取距离 1970-01-01（本地/北京时间）的秒数
        /// </summary>
        /// <param name="localTime"></param>
        /// <returns></returns>
        public static long ToLocalSeconds(this DateTime localTime)
        {
            return (long)(localTime - new DateTime(1970, 1, 1)).TotalSeconds;
        }

        /// <summary>
        /// 距离 1970-01-01（本地/北京时间）的秒数转换为当前时间
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static DateTime FromLocalSeconds(this long seconds)
        {
            return new DateTime(1970, 1, 1).AddSeconds(seconds);
        }

    }
}
