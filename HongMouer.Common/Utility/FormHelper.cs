using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.Common.Utility
{
    ////原文链接:https://www.cnblogs.com/xiaoshuai/archive/2010/06/05/1752353.html

    ///// <summary>
    ///// 子父窗体的设置，获取其子窗体
    ///// </summary>
    //public class FormHelper
    //{/// <summary>
    // /// 设置子窗体
    // /// </summary>
    // /// <param name="type">类型</param>
    // /// <param name="parent">父窗体</param>
    // /// <returns></returns>
    //    public static Form ShowForm(Type type, Form parent)
    //    {
    //        Form retForm;
    //        if (!ChildExists(type, parent, true, out retForm))
    //        {
    //            ConstructorInfo[] cons = type.GetConstructors();
    //            if (cons.Length > 0)
    //            {
    //                Object obj = cons[0].Invoke(null);
    //                if (obj is Form)
    //                {
    //                    retForm = obj as Form;
    //                    retForm.MdiParent = parent;
    //                    retForm.Show();
    //                    retForm.Activate();
    //                }
    //            }
    //        }
    //        return retForm;
    //    }
    //    /// <summary>
    //    /// 子窗体是否存在
    //    /// </summary>
    //    /// <param name="type">类型</param>
    //    /// <param name="parent">父窗体</param>
    //    /// <param name="showForm">是否显示</param>
    //    /// <param name="form">子窗体</param>
    //    /// <returns></returns>
    //    public static bool ChildExists(Type type, Form parent, bool showForm, out Form form)
    //    {
    //        for (int i = 0; i < parent.MdiChildren.Length; i++)
    //        {
    //            Form child = parent.MdiChildren[i];
    //            if (child.GetType() == type)
    //            {
    //                if (showForm)
    //                {
    //                    child.Visible = true;
    //                    child.Activate();
    //                }
    //                form = child;
    //                return true;
    //            }
    //        }
    //        form = null;
    //        return false;
    //    }

    //}
}
