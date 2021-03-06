﻿using CTS.Track.Common.LogHelper;
using Ganss.XSS;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTS.Track.Api.Filter
{

    public class XSSFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        private readonly HtmlSanitizer htmlSanitizer;

        public XSSFilterAttribute()
        {
            htmlSanitizer = new HtmlSanitizer();
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            try
            {
                //获取Action参数集合
                var ps = context.ActionDescriptor.Parameters;
                //遍历参数集合
                foreach (var p in ps)
                {
                    if (context.ActionArguments[p.Name] != null)
                    {
                        //当参数等于字符串
                        if (p.ParameterType.Equals(typeof(string)))
                        {
                            context.ActionArguments[p.Name] = htmlSanitizer.Sanitize(context.ActionArguments[p.Name].ToString());
                        }
                        else if (p.ParameterType.IsClass)//当参数等于类
                        {
                            ModelFieldFilter(p.Name, p.ParameterType, context.ActionArguments[p.Name]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// 遍历修改类的字符串属性
        /// </summary>
        /// <param name="key">类名</param>
        /// <param name="t">数据类型</param>
        /// <param name="obj">对象</param>
        /// <returns></returns>
        private object ModelFieldFilter(string key, Type t, object obj)
        {
            //获取类的属性集合
            //var ats = t.GetCustomAttributes(typeof(FieldFilterAttribute), false);
            if (obj != null)
            {
                //获取类的属性集合
                var pps = t.GetProperties();

                foreach (var pp in pps)
                {
                    if (pp.GetValue(obj) != null)
                    {
                        //当属性等于字符串
                        if (pp.PropertyType.Equals(typeof(string)))
                        {
                            string value = pp.GetValue(obj).ToString();
                            pp.SetValue(obj, htmlSanitizer.Sanitize(value));
                        }
                        else if (pp.PropertyType.IsClass)//当属性等于类进行递归
                        {
                            pp.SetValue(obj, ModelFieldFilter(pp.Name, pp.PropertyType, pp.GetValue(obj)));
                        }
                    }

                }
            }

            return obj;
        }
    }

}

